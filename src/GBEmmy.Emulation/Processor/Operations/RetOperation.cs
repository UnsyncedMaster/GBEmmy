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

namespace GBEmmy.Emulation.Processor.Operations
{
    /// <summary>
    /// RET [operand1]: If operand1 is a true assertion or empty, return pop a word from the stack to the PC-register.
    /// </summary>
    public class RetOperation : IOperation
    {
        public bool Call(Z80 cpu, Operand operand1, Operand operand2, byte embedded)
        {
            if (cpu.Flags[operand1])
            {
                cpu.PC = (ushort) (cpu.Memory[cpu.SP++] | (cpu.Memory[cpu.SP++] << 8));
                return true;
            }

            return false;
        }
    }
}