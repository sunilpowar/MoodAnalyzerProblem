using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;


namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("SAD Mood")]
        public void GivenMessageShouldReturnHappy()
        {
            ///Follow AAA strategy
            ///Arrange , Act and in last Assert
            AnalyzeMood mood = new AnalyzeMood();
            string message = "I am in Sad Mood";
            string excepted = "SAD";
            var actual = mood.Mood(message);
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("HAPPY Mood")]
        public void GivenMessageShouldReturnSad()
        {
            ///Follow AAA strategy
            ///Arrange , Act and in last Assert
            AnalyzeMood mood = new AnalyzeMood();
            string message = "I am in any Mood";
            string excepted = "HAPPY";
            var actual = mood.Mood(message);
            Assert.AreEqual(excepted, actual);
        }
    }
}
