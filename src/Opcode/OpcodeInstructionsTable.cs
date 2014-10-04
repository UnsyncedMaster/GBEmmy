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

namespace GBEmmy.Opcode
{
    public static class OpcodeInstructionsTable
    {
        #region Cb

        public static readonly OpcodeInstruction[] Cb =
        {
            new OpcodeInstruction("RLC B", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RLC C", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RLC D", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RLC E", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RLC H", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RLC L", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RLC (HL)", "Z 0 0 C", 2, 16),
            new OpcodeInstruction("RLC A", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RRC B", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RRC C", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RRC D", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RRC E", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RRC H", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RRC L", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RRC (HL)", "Z 0 0 C", 2, 16),
            new OpcodeInstruction("RRC A", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RL B", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RL C", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RL D", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RL E", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RL H", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RL L", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RL (HL)", "Z 0 0 C", 2, 16),
            new OpcodeInstruction("RL A", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RR B", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RR C", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RR D", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RR E", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RR H", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RR L", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("RR (HL)", "Z 0 0 C", 2, 16),
            new OpcodeInstruction("RR A", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("SLA B", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("SLA C", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("SLA D", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("SLA E", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("SLA H", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("SLA L", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("SLA (HL)", "Z 0 0 C", 2, 16),
            new OpcodeInstruction("SLA A", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("SRA B", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("SRA C", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("SRA D", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("SRA E", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("SRA H", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("SRA L", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("SRA (HL)", "Z 0 0 0", 2, 16),
            new OpcodeInstruction("SRA A", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("SWAP B", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("SWAP C", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("SWAP D", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("SWAP E", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("SWAP H", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("SWAP L", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("SWAP (HL)", "Z 0 0 0", 2, 16),
            new OpcodeInstruction("SWAP A", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("SRL B", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("SRL C", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("SRL D", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("SRL E", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("SRL H", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("SRL L", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("SRL (HL)", "Z 0 0 C", 2, 16),
            new OpcodeInstruction("SRL A", "Z 0 0 C", 2, 8),
            new OpcodeInstruction("BIT 0,B", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 0,C", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 0,D", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 0,E", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 0,H", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 0,L", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 0,(HL)", "Z 0 1 -", 2, 16),
            new OpcodeInstruction("BIT 0,A", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 1,B", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 1,C", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 1,D", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 1,E", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 1,H", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 1,L", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 1,(HL)", "Z 0 1 -", 2, 16),
            new OpcodeInstruction("BIT 1,A", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 2,B", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 2,C", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 2,D", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 2,E", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 2,H", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 2,L", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 2,(HL)", "Z 0 1 -", 2, 16),
            new OpcodeInstruction("BIT 2,A", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 3,B", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 3,C", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 3,D", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 3,E", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 3,H", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 3,L", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 3,(HL)", "Z 0 1 -", 2, 16),
            new OpcodeInstruction("BIT 3,A", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 4,B", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 4,C", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 4,D", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 4,E", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 4,H", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 4,L", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 4,(HL)", "Z 0 1 -", 2, 16),
            new OpcodeInstruction("BIT 4,A", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 5,B", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 5,C", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 5,D", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 5,E", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 5,H", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 5,L", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 5,(HL)", "Z 0 1 -", 2, 16),
            new OpcodeInstruction("BIT 5,A", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 6,B", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 6,C", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 6,D", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 6,E", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 6,H", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 6,L", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 6,(HL)", "Z 0 1 -", 2, 16),
            new OpcodeInstruction("BIT 6,A", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 7,B", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 7,C", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 7,D", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 7,E", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 7,H", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 7,L", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("BIT 7,(HL)", "Z 0 1 -", 2, 16),
            new OpcodeInstruction("BIT 7,A", "Z 0 1 -", 2, 8),
            new OpcodeInstruction("RES 0,B", "- - - -", 2, 8),
            new OpcodeInstruction("RES 0,C", "- - - -", 2, 8),
            new OpcodeInstruction("RES 0,D", "- - - -", 2, 8),
            new OpcodeInstruction("RES 0,E", "- - - -", 2, 8),
            new OpcodeInstruction("RES 0,H", "- - - -", 2, 8),
            new OpcodeInstruction("RES 0,L", "- - - -", 2, 8),
            new OpcodeInstruction("RES 0,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("RES 0,A", "- - - -", 2, 8),
            new OpcodeInstruction("RES 1,B", "- - - -", 2, 8),
            new OpcodeInstruction("RES 1,C", "- - - -", 2, 8),
            new OpcodeInstruction("RES 1,D", "- - - -", 2, 8),
            new OpcodeInstruction("RES 1,E", "- - - -", 2, 8),
            new OpcodeInstruction("RES 1,H", "- - - -", 2, 8),
            new OpcodeInstruction("RES 1,L", "- - - -", 2, 8),
            new OpcodeInstruction("RES 1,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("RES 1,A", "- - - -", 2, 8),
            new OpcodeInstruction("RES 2,B", "- - - -", 2, 8),
            new OpcodeInstruction("RES 2,C", "- - - -", 2, 8),
            new OpcodeInstruction("RES 2,D", "- - - -", 2, 8),
            new OpcodeInstruction("RES 2,E", "- - - -", 2, 8),
            new OpcodeInstruction("RES 2,H", "- - - -", 2, 8),
            new OpcodeInstruction("RES 2,L", "- - - -", 2, 8),
            new OpcodeInstruction("RES 2,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("RES 2,A", "- - - -", 2, 8),
            new OpcodeInstruction("RES 3,B", "- - - -", 2, 8),
            new OpcodeInstruction("RES 3,C", "- - - -", 2, 8),
            new OpcodeInstruction("RES 3,D", "- - - -", 2, 8),
            new OpcodeInstruction("RES 3,E", "- - - -", 2, 8),
            new OpcodeInstruction("RES 3,H", "- - - -", 2, 8),
            new OpcodeInstruction("RES 3,L", "- - - -", 2, 8),
            new OpcodeInstruction("RES 3,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("RES 3,A", "- - - -", 2, 8),
            new OpcodeInstruction("RES 4,B", "- - - -", 2, 8),
            new OpcodeInstruction("RES 4,C", "- - - -", 2, 8),
            new OpcodeInstruction("RES 4,D", "- - - -", 2, 8),
            new OpcodeInstruction("RES 4,E", "- - - -", 2, 8),
            new OpcodeInstruction("RES 4,H", "- - - -", 2, 8),
            new OpcodeInstruction("RES 4,L", "- - - -", 2, 8),
            new OpcodeInstruction("RES 4,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("RES 4,A", "- - - -", 2, 8),
            new OpcodeInstruction("RES 5,B", "- - - -", 2, 8),
            new OpcodeInstruction("RES 5,C", "- - - -", 2, 8),
            new OpcodeInstruction("RES 5,D", "- - - -", 2, 8),
            new OpcodeInstruction("RES 5,E", "- - - -", 2, 8),
            new OpcodeInstruction("RES 5,H", "- - - -", 2, 8),
            new OpcodeInstruction("RES 5,L", "- - - -", 2, 8),
            new OpcodeInstruction("RES 5,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("RES 5,A", "- - - -", 2, 8),
            new OpcodeInstruction("RES 6,B", "- - - -", 2, 8),
            new OpcodeInstruction("RES 6,C", "- - - -", 2, 8),
            new OpcodeInstruction("RES 6,D", "- - - -", 2, 8),
            new OpcodeInstruction("RES 6,E", "- - - -", 2, 8),
            new OpcodeInstruction("RES 6,H", "- - - -", 2, 8),
            new OpcodeInstruction("RES 6,L", "- - - -", 2, 8),
            new OpcodeInstruction("RES 6,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("RES 6,A", "- - - -", 2, 8),
            new OpcodeInstruction("RES 7,B", "- - - -", 2, 8),
            new OpcodeInstruction("RES 7,C", "- - - -", 2, 8),
            new OpcodeInstruction("RES 7,D", "- - - -", 2, 8),
            new OpcodeInstruction("RES 7,E", "- - - -", 2, 8),
            new OpcodeInstruction("RES 7,H", "- - - -", 2, 8),
            new OpcodeInstruction("RES 7,L", "- - - -", 2, 8),
            new OpcodeInstruction("RES 7,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("RES 7,A", "- - - -", 2, 8),
            new OpcodeInstruction("SET 0,B", "- - - -", 2, 8),
            new OpcodeInstruction("SET 0,C", "- - - -", 2, 8),
            new OpcodeInstruction("SET 0,D", "- - - -", 2, 8),
            new OpcodeInstruction("SET 0,E", "- - - -", 2, 8),
            new OpcodeInstruction("SET 0,H", "- - - -", 2, 8),
            new OpcodeInstruction("SET 0,L", "- - - -", 2, 8),
            new OpcodeInstruction("SET 0,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("SET 0,A", "- - - -", 2, 8),
            new OpcodeInstruction("SET 1,B", "- - - -", 2, 8),
            new OpcodeInstruction("SET 1,C", "- - - -", 2, 8),
            new OpcodeInstruction("SET 1,D", "- - - -", 2, 8),
            new OpcodeInstruction("SET 1,E", "- - - -", 2, 8),
            new OpcodeInstruction("SET 1,H", "- - - -", 2, 8),
            new OpcodeInstruction("SET 1,L", "- - - -", 2, 8),
            new OpcodeInstruction("SET 1,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("SET 1,A", "- - - -", 2, 8),
            new OpcodeInstruction("SET 2,B", "- - - -", 2, 8),
            new OpcodeInstruction("SET 2,C", "- - - -", 2, 8),
            new OpcodeInstruction("SET 2,D", "- - - -", 2, 8),
            new OpcodeInstruction("SET 2,E", "- - - -", 2, 8),
            new OpcodeInstruction("SET 2,H", "- - - -", 2, 8),
            new OpcodeInstruction("SET 2,L", "- - - -", 2, 8),
            new OpcodeInstruction("SET 2,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("SET 2,A", "- - - -", 2, 8),
            new OpcodeInstruction("SET 3,B", "- - - -", 2, 8),
            new OpcodeInstruction("SET 3,C", "- - - -", 2, 8),
            new OpcodeInstruction("SET 3,D", "- - - -", 2, 8),
            new OpcodeInstruction("SET 3,E", "- - - -", 2, 8),
            new OpcodeInstruction("SET 3,H", "- - - -", 2, 8),
            new OpcodeInstruction("SET 3,L", "- - - -", 2, 8),
            new OpcodeInstruction("SET 3,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("SET 3,A", "- - - -", 2, 8),
            new OpcodeInstruction("SET 4,B", "- - - -", 2, 8),
            new OpcodeInstruction("SET 4,C", "- - - -", 2, 8),
            new OpcodeInstruction("SET 4,D", "- - - -", 2, 8),
            new OpcodeInstruction("SET 4,E", "- - - -", 2, 8),
            new OpcodeInstruction("SET 4,H", "- - - -", 2, 8),
            new OpcodeInstruction("SET 4,L", "- - - -", 2, 8),
            new OpcodeInstruction("SET 4,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("SET 4,A", "- - - -", 2, 8),
            new OpcodeInstruction("SET 5,B", "- - - -", 2, 8),
            new OpcodeInstruction("SET 5,C", "- - - -", 2, 8),
            new OpcodeInstruction("SET 5,D", "- - - -", 2, 8),
            new OpcodeInstruction("SET 5,E", "- - - -", 2, 8),
            new OpcodeInstruction("SET 5,H", "- - - -", 2, 8),
            new OpcodeInstruction("SET 5,L", "- - - -", 2, 8),
            new OpcodeInstruction("SET 5,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("SET 5,A", "- - - -", 2, 8),
            new OpcodeInstruction("SET 6,B", "- - - -", 2, 8),
            new OpcodeInstruction("SET 6,C", "- - - -", 2, 8),
            new OpcodeInstruction("SET 6,D", "- - - -", 2, 8),
            new OpcodeInstruction("SET 6,E", "- - - -", 2, 8),
            new OpcodeInstruction("SET 6,H", "- - - -", 2, 8),
            new OpcodeInstruction("SET 6,L", "- - - -", 2, 8),
            new OpcodeInstruction("SET 6,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("SET 6,A", "- - - -", 2, 8),
            new OpcodeInstruction("SET 7,B", "- - - -", 2, 8),
            new OpcodeInstruction("SET 7,C", "- - - -", 2, 8),
            new OpcodeInstruction("SET 7,D", "- - - -", 2, 8),
            new OpcodeInstruction("SET 7,E", "- - - -", 2, 8),
            new OpcodeInstruction("SET 7,H", "- - - -", 2, 8),
            new OpcodeInstruction("SET 7,L", "- - - -", 2, 8),
            new OpcodeInstruction("SET 7,(HL)", "- - - -", 2, 16),
            new OpcodeInstruction("SET 7,A", "- - - -", 2, 8)
        };

        #endregion

        #region Base

        public static readonly OpcodeInstruction[] Base =
        {
            new OpcodeInstruction("NOP", "- - - -", 1, 4),
            new OpcodeInstruction("LD BC,d16", "- - - -", 3, 12),
            new OpcodeInstruction("LD (BC),A", "- - - -", 1, 8),
            new OpcodeInstruction("INC BC", "- - - -", 1, 8),
            new OpcodeInstruction("INC B", "Z 0 H -", 1, 4),
            new OpcodeInstruction("DEC B", "Z 1 H -", 1, 4),
            new OpcodeInstruction("LD B,d8", "- - - -", 2, 8),
            new OpcodeInstruction("RLCA", "0 0 0 C", 1, 4),
            new OpcodeInstruction("LD (a16),SP", "- - - -", 3, 20),
            new OpcodeInstruction("ADD HL,BC", "- 0 H C", 1, 8),
            new OpcodeInstruction("LD A,(BC)", "- - - -", 1, 8),
            new OpcodeInstruction("DEC BC", "- - - -", 1, 8),
            new OpcodeInstruction("INC C", "Z 0 H -", 1, 4),
            new OpcodeInstruction("DEC C", "Z 1 H -", 1, 4),
            new OpcodeInstruction("LD C,d8", "- - - -", 2, 8),
            new OpcodeInstruction("RRCA", "0 0 0 C", 1, 4),
            new OpcodeInstruction("STOP 0", "- - - -", 2, 4),
            new OpcodeInstruction("LD DE,d16", "- - - -", 3, 12),
            new OpcodeInstruction("LD (DE),A", "- - - -", 1, 8),
            new OpcodeInstruction("INC DE", "- - - -", 1, 8),
            new OpcodeInstruction("INC D", "Z 0 H -", 1, 4),
            new OpcodeInstruction("DEC D", "Z 1 H -", 1, 4),
            new OpcodeInstruction("LD D,d8", "- - - -", 2, 8),
            new OpcodeInstruction("RLA", "0 0 0 C", 1, 4),
            new OpcodeInstruction("JR r8", "- - - -", 2, 12),
            new OpcodeInstruction("ADD HL,DE", "- 0 H C", 1, 8),
            new OpcodeInstruction("LD A,(DE)", "- - - -", 1, 8),
            new OpcodeInstruction("DEC DE", "- - - -", 1, 8),
            new OpcodeInstruction("INC E", "Z 0 H -", 1, 4),
            new OpcodeInstruction("DEC E", "Z 1 H -", 1, 4),
            new OpcodeInstruction("LD E,d8", "- - - -", 2, 8),
            new OpcodeInstruction("RRA", "0 0 0 C", 1, 4),
            new OpcodeInstruction("JR NZ,r8", "- - - -", 2, 12/8),
            new OpcodeInstruction("LD HL,d16", "- - - -", 3, 12),
            new OpcodeInstruction("LDI (HL),A", "- - - -", 1, 8),
            new OpcodeInstruction("INC HL", "- - - -", 1, 8),
            new OpcodeInstruction("INC H", "Z 0 H -", 1, 4),
            new OpcodeInstruction("DEC H", "Z 1 H -", 1, 4),
            new OpcodeInstruction("LD H,d8", "- - - -", 2, 8),
            new OpcodeInstruction("DAA", "Z - 0 C", 1, 4),
            new OpcodeInstruction("JR Z,r8", "- - - -", 2, 12/8),
            new OpcodeInstruction("ADD HL,HL", "- 0 H C", 1, 8),
            new OpcodeInstruction("LDI A,(HL)", "- - - -", 1, 8),
            new OpcodeInstruction("DEC HL", "- - - -", 1, 8),
            new OpcodeInstruction("INC L", "Z 0 H -", 1, 4),
            new OpcodeInstruction("DEC L", "Z 1 H -", 1, 4),
            new OpcodeInstruction("LD L,d8", "- - - -", 2, 8),
            new OpcodeInstruction("CPL", "- 1 1 -", 1, 4),
            new OpcodeInstruction("JR NC,r8", "- - - -", 2, 12/8),
            new OpcodeInstruction("LD SP,d16", "- - - -", 3, 12),
            new OpcodeInstruction("LDD (HL),A", "- - - -", 1, 8),
            new OpcodeInstruction("INC SP", "- - - -", 1, 8),
            new OpcodeInstruction("INC (HL)", "Z 0 H -", 1, 12),
            new OpcodeInstruction("DEC (HL)", "Z 1 H -", 1, 12),
            new OpcodeInstruction("LD (HL),d8", "- - - -", 2, 12),
            new OpcodeInstruction("SCF", "- 0 0 1", 1, 4),
            new OpcodeInstruction("JR C,r8", "- - - -", 2, 12/8),
            new OpcodeInstruction("ADD HL,SP", "- 0 H C", 1, 8),
            new OpcodeInstruction("LDD A,(HL)", "- - - -", 1, 8),
            new OpcodeInstruction("DEC SP", "- - - -", 1, 8),
            new OpcodeInstruction("INC A", "Z 0 H -", 1, 4),
            new OpcodeInstruction("DEC A", "Z 1 H -", 1, 4),
            new OpcodeInstruction("LD A,d8", "- - - -", 2, 8),
            new OpcodeInstruction("CCF", "- 0 0 C", 1, 4),
            new OpcodeInstruction("LD B,B", "- - - -", 1, 4),
            new OpcodeInstruction("LD B,C", "- - - -", 1, 4),
            new OpcodeInstruction("LD B,D", "- - - -", 1, 4),
            new OpcodeInstruction("LD B,E", "- - - -", 1, 4),
            new OpcodeInstruction("LD B,H", "- - - -", 1, 4),
            new OpcodeInstruction("LD B,L", "- - - -", 1, 4),
            new OpcodeInstruction("LD B,(HL)", "- - - -", 1, 8),
            new OpcodeInstruction("LD B,A", "- - - -", 1, 4),
            new OpcodeInstruction("LD C,B", "- - - -", 1, 4),
            new OpcodeInstruction("LD C,C", "- - - -", 1, 4),
            new OpcodeInstruction("LD C,D", "- - - -", 1, 4),
            new OpcodeInstruction("LD C,E", "- - - -", 1, 4),
            new OpcodeInstruction("LD C,H", "- - - -", 1, 4),
            new OpcodeInstruction("LD C,L", "- - - -", 1, 4),
            new OpcodeInstruction("LD C,(HL)", "- - - -", 1, 8),
            new OpcodeInstruction("LD C,A", "- - - -", 1, 4),
            new OpcodeInstruction("LD D,B", "- - - -", 1, 4),
            new OpcodeInstruction("LD D,C", "- - - -", 1, 4),
            new OpcodeInstruction("LD D,D", "- - - -", 1, 4),
            new OpcodeInstruction("LD D,E", "- - - -", 1, 4),
            new OpcodeInstruction("LD D,H", "- - - -", 1, 4),
            new OpcodeInstruction("LD D,L", "- - - -", 1, 4),
            new OpcodeInstruction("LD D,(HL)", "- - - -", 1, 8),
            new OpcodeInstruction("LD D,A", "- - - -", 1, 4),
            new OpcodeInstruction("LD E,B", "- - - -", 1, 4),
            new OpcodeInstruction("LD E,C", "- - - -", 1, 4),
            new OpcodeInstruction("LD E,D", "- - - -", 1, 4),
            new OpcodeInstruction("LD E,E", "- - - -", 1, 4),
            new OpcodeInstruction("LD E,H", "- - - -", 1, 4),
            new OpcodeInstruction("LD E,L", "- - - -", 1, 4),
            new OpcodeInstruction("LD E,(HL)", "- - - -", 1, 8),
            new OpcodeInstruction("LD E,A", "- - - -", 1, 4),
            new OpcodeInstruction("LD H,B", "- - - -", 1, 4),
            new OpcodeInstruction("LD H,C", "- - - -", 1, 4),
            new OpcodeInstruction("LD H,D", "- - - -", 1, 4),
            new OpcodeInstruction("LD H,E", "- - - -", 1, 4),
            new OpcodeInstruction("LD H,H", "- - - -", 1, 4),
            new OpcodeInstruction("LD H,L", "- - - -", 1, 4),
            new OpcodeInstruction("LD H,(HL)", "- - - -", 1, 8),
            new OpcodeInstruction("LD H,A", "- - - -", 1, 4),
            new OpcodeInstruction("LD L,B", "- - - -", 1, 4),
            new OpcodeInstruction("LD L,C", "- - - -", 1, 4),
            new OpcodeInstruction("LD L,D", "- - - -", 1, 4),
            new OpcodeInstruction("LD L,E", "- - - -", 1, 4),
            new OpcodeInstruction("LD L,H", "- - - -", 1, 4),
            new OpcodeInstruction("LD L,L", "- - - -", 1, 4),
            new OpcodeInstruction("LD L,(HL)", "- - - -", 1, 8),
            new OpcodeInstruction("LD L,A", "- - - -", 1, 4),
            new OpcodeInstruction("LD (HL),B", "- - - -", 1, 8),
            new OpcodeInstruction("LD (HL),C", "- - - -", 1, 8),
            new OpcodeInstruction("LD (HL),D", "- - - -", 1, 8),
            new OpcodeInstruction("LD (HL),E", "- - - -", 1, 8),
            new OpcodeInstruction("LD (HL),H", "- - - -", 1, 8),
            new OpcodeInstruction("LD (HL),L", "- - - -", 1, 8),
            new OpcodeInstruction("HALT", "- - - -", 1, 4),
            new OpcodeInstruction("LD (HL),A", "- - - -", 1, 8),
            new OpcodeInstruction("LD A,B", "- - - -", 1, 4),
            new OpcodeInstruction("LD A,C", "- - - -", 1, 4),
            new OpcodeInstruction("LD A,D", "- - - -", 1, 4),
            new OpcodeInstruction("LD A,E", "- - - -", 1, 4),
            new OpcodeInstruction("LD A,H", "- - - -", 1, 4),
            new OpcodeInstruction("LD A,L", "- - - -", 1, 4),
            new OpcodeInstruction("LD A,(HL)", "- - - -", 1, 8),
            new OpcodeInstruction("LD A,A", "- - - -", 1, 4),
            new OpcodeInstruction("ADD A,B", "Z 0 H C", 1, 4),
            new OpcodeInstruction("ADD A,C", "Z 0 H C", 1, 4),
            new OpcodeInstruction("ADD A,D", "Z 0 H C", 1, 4),
            new OpcodeInstruction("ADD A,E", "Z 0 H C", 1, 4),
            new OpcodeInstruction("ADD A,H", "Z 0 H C", 1, 4),
            new OpcodeInstruction("ADD A,L", "Z 0 H C", 1, 4),
            new OpcodeInstruction("ADD A,(HL)", "Z 0 H C", 1, 8),
            new OpcodeInstruction("ADD A,A", "Z 0 H C", 1, 4),
            new OpcodeInstruction("ADC A,B", "Z 0 H C", 1, 4),
            new OpcodeInstruction("ADC A,C", "Z 0 H C", 1, 4),
            new OpcodeInstruction("ADC A,D", "Z 0 H C", 1, 4),
            new OpcodeInstruction("ADC A,E", "Z 0 H C", 1, 4),
            new OpcodeInstruction("ADC A,H", "Z 0 H C", 1, 4),
            new OpcodeInstruction("ADC A,L", "Z 0 H C", 1, 4),
            new OpcodeInstruction("ADC A,(HL)", "Z 0 H C", 1, 8),
            new OpcodeInstruction("ADC A,A", "Z 0 H C", 1, 4),
            new OpcodeInstruction("SUB B", "Z 1 H C", 1, 4),
            new OpcodeInstruction("SUB C", "Z 1 H C", 1, 4),
            new OpcodeInstruction("SUB D", "Z 1 H C", 1, 4),
            new OpcodeInstruction("SUB E", "Z 1 H C", 1, 4),
            new OpcodeInstruction("SUB H", "Z 1 H C", 1, 4),
            new OpcodeInstruction("SUB L", "Z 1 H C", 1, 4),
            new OpcodeInstruction("SUB (HL)", "Z 1 H C", 1, 8),
            new OpcodeInstruction("SUB A", "Z 1 H C", 1, 4),
            new OpcodeInstruction("SBC A,B", "Z 1 H C", 1, 4),
            new OpcodeInstruction("SBC A,C", "Z 1 H C", 1, 4),
            new OpcodeInstruction("SBC A,D", "Z 1 H C", 1, 4),
            new OpcodeInstruction("SBC A,E", "Z 1 H C", 1, 4),
            new OpcodeInstruction("SBC A,H", "Z 1 H C", 1, 4),
            new OpcodeInstruction("SBC A,L", "Z 1 H C", 1, 4),
            new OpcodeInstruction("SBC A,(HL)", "Z 1 H C", 1, 8),
            new OpcodeInstruction("SBC A,A", "Z 1 H C", 1, 4),
            new OpcodeInstruction("AND B", "Z 0 1 0", 1, 4),
            new OpcodeInstruction("AND C", "Z 0 1 0", 1, 4),
            new OpcodeInstruction("AND D", "Z 0 1 0", 1, 4),
            new OpcodeInstruction("AND E", "Z 0 1 0", 1, 4),
            new OpcodeInstruction("AND H", "Z 0 1 0", 1, 4),
            new OpcodeInstruction("AND L", "Z 0 1 0", 1, 4),
            new OpcodeInstruction("AND (HL)", "Z 0 1 0", 1, 8),
            new OpcodeInstruction("AND A", "Z 0 1 0", 1, 4),
            new OpcodeInstruction("XOR B", "Z 0 0 0", 1, 4),
            new OpcodeInstruction("XOR C", "Z 0 0 0", 1, 4),
            new OpcodeInstruction("XOR D", "Z 0 0 0", 1, 4),
            new OpcodeInstruction("XOR E", "Z 0 0 0", 1, 4),
            new OpcodeInstruction("XOR H", "Z 0 0 0", 1, 4),
            new OpcodeInstruction("XOR L", "Z 0 0 0", 1, 4),
            new OpcodeInstruction("XOR (HL)", "Z 0 0 0", 1, 8),
            new OpcodeInstruction("XOR A", "Z 0 0 0", 1, 4),
            new OpcodeInstruction("OR B", "Z 0 0 0", 1, 4),
            new OpcodeInstruction("OR C", "Z 0 0 0", 1, 4),
            new OpcodeInstruction("OR D", "Z 0 0 0", 1, 4),
            new OpcodeInstruction("OR E", "Z 0 0 0", 1, 4),
            new OpcodeInstruction("OR H", "Z 0 0 0", 1, 4),
            new OpcodeInstruction("OR L", "Z 0 0 0", 1, 4),
            new OpcodeInstruction("OR (HL)", "Z 0 0 0", 1, 8),
            new OpcodeInstruction("OR A", "Z 0 0 0", 1, 4),
            new OpcodeInstruction("CP B", "Z 1 H C", 1, 4),
            new OpcodeInstruction("CP C", "Z 1 H C", 1, 4),
            new OpcodeInstruction("CP D", "Z 1 H C", 1, 4),
            new OpcodeInstruction("CP E", "Z 1 H C", 1, 4),
            new OpcodeInstruction("CP H", "Z 1 H C", 1, 4),
            new OpcodeInstruction("CP L", "Z 1 H C", 1, 4),
            new OpcodeInstruction("CP (HL)", "Z 1 H C", 1, 8),
            new OpcodeInstruction("CP A", "Z 1 H C", 1, 4),
            new OpcodeInstruction("RET NZ", "- - - -", 1, 20/8),
            new OpcodeInstruction("POP BC", "- - - -", 1, 12),
            new OpcodeInstruction("JP NZ,a16", "- - - -", 3, 16, 12),
            new OpcodeInstruction("JP a16", "- - - -", 3, 16),
            new OpcodeInstruction("CALL NZ,a16", "- - - -", 3, 24, 12),
            new OpcodeInstruction("PUSH BC", "- - - -", 1, 16),
            new OpcodeInstruction("ADD A,d8", "Z 0 H C", 2, 8),
            new OpcodeInstruction("RST 00H", "- - - -", 1, 16),
            new OpcodeInstruction("RET Z", "- - - -", 1, 20/8),
            new OpcodeInstruction("RET", "- - - -", 1, 16),
            new OpcodeInstruction("JP Z,a16", "- - - -", 3, 16, 12),
            new OpcodeInstruction(), // new OpcodeInstruction("PREFIX CB", "- - - -", 1, 4),
            new OpcodeInstruction("CALL Z,a16", "- - - -", 3, 24, 12),
            new OpcodeInstruction("CALL a16", "- - - -", 3, 24),
            new OpcodeInstruction("ADC A,d8", "Z 0 H C", 2, 8),
            new OpcodeInstruction("RST 08H", "- - - -", 1, 16),
            new OpcodeInstruction("RET NC", "- - - -", 1, 20/8),
            new OpcodeInstruction("POP DE", "- - - -", 1, 12),
            new OpcodeInstruction("JP NC,a16", "- - - -", 3, 16, 12),
            new OpcodeInstruction("EMPTY", "- - - -", 0, 0),
            new OpcodeInstruction("CALL NC,a16", "- - - -", 3, 24, 12),
            new OpcodeInstruction("PUSH DE", "- - - -", 1, 16),
            new OpcodeInstruction("SUB d8", "Z 1 H C", 2, 8),
            new OpcodeInstruction("RST 10H", "- - - -", 1, 16),
            new OpcodeInstruction("RET C", "- - - -", 1, 20/8),
            new OpcodeInstruction("RETI", "- - - -", 1, 16),
            new OpcodeInstruction("JP C,a16", "- - - -", 3, 16, 12),
            new OpcodeInstruction("EMPTY", "- - - -", 0, 0),
            new OpcodeInstruction("CALL C,a16", "- - - -", 3, 24, 12),
            new OpcodeInstruction("EMPTY", "- - - -", 0, 0),
            new OpcodeInstruction("SBC A,d8", "Z 1 H C", 2, 8),
            new OpcodeInstruction("RST 18H", "- - - -", 1, 16),
            new OpcodeInstruction("LDH (a8),A", "- - - -", 2, 12),
            new OpcodeInstruction("POP HL", "- - - -", 1, 12),
            new OpcodeInstruction("LD (C),A", "- - - -", 2, 8),
            new OpcodeInstruction("EMPTY", "- - - -", 0, 0),
            new OpcodeInstruction("EMPTY", "- - - -", 0, 0),
            new OpcodeInstruction("PUSH HL", "- - - -", 1, 16),
            new OpcodeInstruction("AND d8", "Z 0 1 0", 2, 8),
            new OpcodeInstruction("RST 20H", "- - - -", 1, 16),
            new OpcodeInstruction("ADD SP,r8", "0 0 H C", 2, 16),
            new OpcodeInstruction("JP (HL)", "- - - -", 1, 4),
            new OpcodeInstruction("LD (a16),A", "- - - -", 3, 16),
            new OpcodeInstruction("EMPTY", "- - - -", 0, 0),
            new OpcodeInstruction("EMPTY", "- - - -", 0, 0),
            new OpcodeInstruction("EMPTY", "- - - -", 0, 0),
            new OpcodeInstruction("XOR d8", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("RST 28H", "- - - -", 1, 16),
            new OpcodeInstruction("LDH A,(a8)", "- - - -", 2, 12),
            new OpcodeInstruction("POP AF", "Z N H C", 1, 12),
            new OpcodeInstruction("LD A,(C)", "- - - -", 2, 8),
            new OpcodeInstruction("DI", "- - - -", 1, 4),
            new OpcodeInstruction("EMPTY", "- - - -", 0, 0),
            new OpcodeInstruction("PUSH AF", "- - - -", 1, 16),
            new OpcodeInstruction("OR d8", "Z 0 0 0", 2, 8),
            new OpcodeInstruction("RST 30H", "- - - -", 1, 16),
            new OpcodeInstruction("LDHL SP,r8", "0 0 H C", 2, 12),
            new OpcodeInstruction("LD SP,HL", "- - - -", 1, 8),
            new OpcodeInstruction("LD A,(a16)", "- - - -", 3, 16),
            new OpcodeInstruction("EI", "- - - -", 1, 4),
            new OpcodeInstruction("EMPTY", "- - - -", 0, 0),
            new OpcodeInstruction("EMPTY", "- - - -", 0, 0),
            new OpcodeInstruction("CP d8", "Z 1 H C", 2, 8),
            new OpcodeInstruction("RST 38H", "- - - -", 1, 16)
        };

        #endregion
    }
}