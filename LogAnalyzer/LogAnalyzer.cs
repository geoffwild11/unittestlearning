using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLearning.LogAnalyzer
{
    public class LogAnalyzer
    {
		public bool IsValidLogFileName(string filename)
		{
			if (string.IsNullOrEmpty(filename))
			{
				throw new ArgumentException("filename has to be provided.");
			}

			if (!filename.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
			{
				return false;
			}

			return true;
		}
    }
}
