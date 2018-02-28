using System;
using NUnit.Framework;
using UnitTestLearning.LogAnalyzer;

namespace LogAn.UnitTests
{
	[TestFixture]
	public class LogAnalyzerTests
	{
		private LogAnalyzer _analyzer = null;

		[SetUp]
		public void Setup()
		{
			_analyzer = CreateAnalyzer();
		}

		[Test]
		public void IsValidFileName_BadExtension_ReturnsFalse()
		{
			bool result = _analyzer.IsValidFileName("filewithbadextension.foo");

			Assert.False(result);
		}

		[TestCase("filewithgoodextension.SLF",true)]
		[TestCase("filewithgoodextension.slf",true)]
		public void IsValidFileName_GoodExtension_ReturnsTrue(string filename, bool expected)
		{
			bool result = _analyzer.IsValidFileName(filename);

			Assert.AreEqual(expected, result);
		}

		private LogAnalyzer CreateAnalyzer()
		{
			return new LogAnalyzer();
		}

	}
}
