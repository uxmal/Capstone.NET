﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gee.External.Capstone.PowerPc {
	public static class NativePowerPcInstructionDetailExtension {
		public static PowerPcInstructionDetail AsPowerPcInstructionDetail(this NativePowerPcInstructionDetail @this) {
			var @object = new PowerPcInstructionDetail();
            //TODO: Implement
            @object.BranchCode = (PowerPcBranchCode) @this.BranchCode;
            @object.BranchHint = (PowerPcBranchHint) @this.BranchHint;
            @object.OperandCount = @this.OperandCount;
			//TODO: Operands!
			return @object;
		}
	}
}
