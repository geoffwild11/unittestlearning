using System;
using NUnit.Framework;
using UnitTestLearning.LogAnalyzer;

namespace LogAn.UnitTests
{
	[TestFixture]
	public class LogAnalyzerTests
	{
		[Test]
		public void IsValidFileName_BadExtension_ReturnsFalse()
		{
			LogAnalyzer analyzer = new LogAnalyzer();

			bool result = analyzer.IsValidFileName("filewithbadextension.foo");

			Assert.False(result);
		}
	}
}
