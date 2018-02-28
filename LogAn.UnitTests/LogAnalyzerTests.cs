using System;
using NUnit.Framework;
using UnitTestLearning.LogAnalyzer;

namespace LogAn.UnitTests
{
	[TestFixture]
	public class LogAnalyzerTests
	{
		private LogAnalyzer _analyzer = null;

		//[SetUp]
		//public void Setup()
		//{
		//	_analyzer = CreateAnalyzer();
		//}

		[Test]
		public void IsValidLogFileName_BadExtension_ReturnsFalse()
		{
			LogAnalyzer analyzer = CreateAnalyzer();

			bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");

			Assert.False(result);
		}

		[TestCase("filewithgoodextension.SLF",true)]
		[TestCase("filewithgoodextension.slf",true)]
		public void IsValidLogFileName_GoodExtension_ReturnsTrue(string filename, bool expected)
		{
			LogAnalyzer analyzer = CreateAnalyzer();

			bool result = analyzer.IsValidLogFileName(filename);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void IsValidLogFileName_EmptyFileName_Throws()
		{
			LogAnalyzer analyzer = CreateAnalyzer();

			Exception ex = Assert.Catch<Exception>(() => analyzer.IsValidLogFileName(""));

			StringAssert.Contains("filename has to be provided", ex.Message);
		}

		private LogAnalyzer CreateAnalyzer()
		{
			return new LogAnalyzer();
		}

	}
}
