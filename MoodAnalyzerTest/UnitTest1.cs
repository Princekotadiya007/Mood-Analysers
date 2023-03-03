using MoodAnalyser;
using System.Security.Cryptography.X509Certificates;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        [Test]
        public void GivenSadMood_WhenAnalyzd_ShouldReturnSad()
        {
            MoodAnalyzerProblem moodAnalyzer = new MoodAnalyzerProblem("I Am In Sad Mood");
            string result = moodAnalyzer.AnalyzeeMood();
            Assert.AreEqual(result, "Sad");
        }
        [Test]
        public void GivenSadMood_WhenAnalyzd_ShouldReturnHappy()
        {
            MoodAnalyzerProblem moodAnalyzer = new MoodAnalyzerProblem("I am In Happy Mood");
            string result = moodAnalyzer.AnalyzeeMood();
            Assert.AreEqual("Happy", result);
        }
    }
}