﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLearning.LogAnalyzer
{
    public class LogAnalyzer
    {
		public bool IsValidFileName(string fileName)
		{
			if (!fileName.EndsWith(".SLF"))
			{
				return false;
			}

			return true;
		}
    }
}
