using MoodAnalyser;
using System.Security.Cryptography.X509Certificates;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        MoodAnalyzerProblem moodAnalyzer = new MoodAnalyzerProblem();

        [Test]
        public void GivenSadMood_WhenAnalyzd_ShouldReturnSad()
        {
            string result = moodAnalyzer.AnalyzeeMood("I Am In Sad Mood");
            Assert.AreEqual("Sad", result);
        }
        [Test]
        public void GivenSadMood_WhenAnalyzd_ShouldReturnHappy()
        {
            string result = moodAnalyzer.AnalyzeeMood("I am In Happy Mood");
            Assert.AreEqual("Happy", result);
        }
    }
}