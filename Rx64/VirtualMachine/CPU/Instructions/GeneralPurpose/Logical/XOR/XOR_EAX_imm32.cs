﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Rx64
{
    public partial class CPU
    {
        private void XOR_EAX_imm32()   // opcode: 35 id      
        {
            uint imm32 = GetNextInstructionDword();
            eax ^= imm32;

            ClearFlag(FlagsEnum.OF_OverflowFlag | FlagsEnum.CF_CarryFlag);
            SetSignFlagByDword(eax);
            SetZeroFlagByDword(eax);
            SetParityFlagByDword(eax);
        }
    }
}