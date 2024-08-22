// GBEmmy
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

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using GBEmmy.Cartridges;
using GBEmmy.Processor;

namespace GBEmmy
{
    internal class GameBoy
    {
        private double _time;
        private readonly CancellationTokenSource _cancellationTokenSource;

        private const double TargetInterval = 1000.0 / 60.0; 

        public GameBoy(Z80 processor, GPU videoProcessor)
        {
            Processor = processor;
            VideoProcessor = videoProcessor;
            _cancellationTokenSource = new CancellationTokenSource();
        }

        public GameBoy(Cartridge cartridge)
        {
            Processor = new Z80(cartridge);
            VideoProcessor = new GPU(Processor.Memory);
            _cancellationTokenSource = new CancellationTokenSource();
        }

        public Z80 Processor { get; }
        public GPU VideoProcessor { get; }

        public void Update()
        {
            _time += TargetInterval;

            while (_time > 0.0)
            {
                double duration = VideoProcessor.Run(_time);

                Processor.Run(duration);

                _time -= duration;
            }
        }

        public void Run()
        {
            LoopAsync(_cancellationTokenSource.Token);
        }

        public async Task LoopAsync(CancellationToken cancellationToken)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    var elapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds;
                    stopwatch.Restart();

                    _time += elapsedMilliseconds;

                    while (_time >= TargetInterval)
                    {
                        Update();
                        _time -= TargetInterval;
                    }

                    var timeToWait = TargetInterval - stopwatch.Elapsed.TotalMilliseconds;

                    if (timeToWait > 0)
                    {
                        await Task.Delay(TimeSpan.FromMilliseconds(timeToWait), cancellationToken);
                    }
                }
            }
            catch (TaskCanceledException)
            {
                // Handle The Task Cancellation If Needed Or Wanted
            }
            finally
            {
                stopwatch.Stop();
            }
        }
        public void Stop()
        {
            _cancellationTokenSource.Cancel();
        }
    }
}