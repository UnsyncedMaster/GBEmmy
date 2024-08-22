﻿// GBEmmy
// Copyright (C) 2014 Tim Potze
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
// OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// 
// For more information, please refer to <http://unlicense.org>

using GBEmmy.Memory;
using GBEmmy.Registers;
using GBEmmy.VideoProcessor;

namespace GBEmmy
{
    public class GPU
    {
        public const byte Height = 144;
        public const byte Width = 160;

        private static readonly double[] FrameStateDuration =
        {
            0.00004802, //HBlank
            0.000114, //VBlank
            0.00001931, //ScanlineOAM
            0.00004137 //ScanlineVRAM
        };

        private readonly LCDCRegister _lcdc;
        private readonly LYRegister _ly;
        private readonly MBC _memory;
        private readonly SCXRegister _scx;
        private readonly SCYRegister _scy;
        private readonly STATRegister _stat;

        private readonly TileMap[] _tileMaps;
        public uint[] ScreenBuffer = new uint[Width*Height];

        private double _timeBuffer;

        public GPU(MBC memory)
        {
            _memory = memory;
            _tileMaps = new[] {new TileMap(memory, 0x8000), new TileMap(memory, 0x8800)};

            _ly = memory.Registers.Get<LYRegister>();
            _lcdc = memory.Registers.Get<LCDCRegister>();
            _stat = memory.Registers.Get<STATRegister>();
            _scx = memory.Registers.Get<SCXRegister>();
            _scy = memory.Registers.Get<SCYRegister>();
        }

        private void RenderBackgroundToScreenBuffer(byte line)
        {
            if (!_lcdc.DisplayEnabled)
            {
                Array.Clear(ScreenBuffer, line * Width, Width);
                return;
            }

            if (_lcdc.BackgroundEnabled)
            {
                TileMap map = _tileMaps[_lcdc.BackgroundTileMap];

                int mapY = (_scy.Value + line) % Height;

                int tileRow = (mapY / Tile.Height) * TileMap.Width;

                for (byte x = 0; x < Width; x++)
                { 
                    int mapX = (_scx.Value + x) % Width;

                    int tileColumn = mapX / Tile.Width;

                    var idx = (ushort)(tileRow + tileColumn);

                    Tile tile = map[idx];

                    byte tileX = (byte)(mapX % Tile.Width);
                    byte tileY = (byte)(mapY % Tile.Height);

                    uint c = tile.GetPixel(_memory, tileX, tileY);

                    ScreenBuffer[line * Width + x] = c;
                }
            }
        }

        private void RenderSpritesToScreenBuffer(byte line)
        {
            //TODO
        }

        public double Run(double duration)
        {
            _timeBuffer += duration;

            if (!(_timeBuffer >= FrameStateDuration[(int) _stat.State])) return duration;

            duration = FrameStateDuration[(int) _stat.State];
            switch (_stat.State)
            {
                case FrameState.HBlank:
                    _stat.State = FrameState.ScanlineOAM;
                    break;
                case FrameState.ScanlineOAM:
                    _stat.State = FrameState.ScanlineVRAM;
                    break;
                case FrameState.ScanlineVRAM:

                    if (_ly.Line >= Height)
                    {
                        _stat.State = FrameState.VBlank;
                    }
                    else
                    {
                        //Fill line from VRAM
                        RenderBackgroundToScreenBuffer(_ly.Line);
                        RenderSpritesToScreenBuffer(_ly.Line);

                        _ly.Line++;
                        _stat.State = FrameState.HBlank;
                    }
                    break;
                case FrameState.VBlank:
                    if (_ly.Line++ == 0) _stat.State = FrameState.ScanlineOAM;
                    break;
            }
            return duration;
        }
    }

    public class TileMap
    {
        public const byte Width = 32;
        public const byte Height = 32;
        private readonly ushort _address;

        private readonly LCDCRegister _lcdc;
        private readonly MBC _memory;

        public TileMap(MBC memory, ushort address)
        {
            _memory = memory;
            _address = address;
            _lcdc = _memory.Registers.Get<LCDCRegister>();
        }

        public Tile this[ushort idx]
        {
            get
            {
                byte tileidx = _memory[_address + idx];
                return _lcdc.TileDataTable[tileidx];
            }
        }
    }

    public class TileDataTable
    {
        private readonly ushort _address;
        private readonly bool _isSigned;

        public TileDataTable(ushort address, bool isSigned)
        {
            _address = address;
            _isSigned = isSigned;
        }

        public Tile this[byte idx]
        {
            get
            {
                return _isSigned
                    ? new Tile((ushort) (_address + (((sbyte) idx + 128)*4)))
                    : new Tile((ushort) (_address + idx*4));
            }
        }
    }

    public class Tile
    {
        public const byte Width = 8;
        public const byte Height = 8;

        public Tile(ushort address)
        {
            Address = address;
        }

        public ushort Address { get; private set; }

        public uint GetPixel(MBC memory, byte x, byte y)
        {
            byte l = memory[Address + y*2];
            byte r = memory[Address + y*2 + 1];

            int c = ((l >> x) << 1 | (r >> x));

            uint[] col = {0xFFEFFFDE, 0xFFADD794, 0xFF529273, 0xFF183442};
            return col[c];
        }
    }
}
