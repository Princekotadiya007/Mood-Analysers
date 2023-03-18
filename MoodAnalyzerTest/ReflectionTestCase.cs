using MoodAnalyser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerTest
{
    public class ReflectionTestCase
    {
        [Test]
        public void Return_Obj()
        {
            try
            {
                object expected = new MoodAnalyzerProblem(null);
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalyzerProblem", "MoodAnalyzerProblem");
                expected.Equals(obj);
            }
            catch (MoodAnlyseException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void ClassName_Should_ThrowMoodAnalysisException()
        {
            try
            {
                object expected = new MoodAnalyzerProblem(null);
                object obj = MoodAnalyserFactory.CreateMoodAnalyser(" MoodAnalyser.MoodAnalyzerProblem", "MoodAnalyzerProblem");
            }
            catch (MoodAnlyseException ex)
            {
                Assert.AreEqual("Class Not found", ex.Message);
            }
        }
        [Test]
        public void ConstructorName_Should_ThrowMoodAnalysisException()
        {
            try
            {
                object expected = new MoodAnalyzerProblem(null);
                object actual = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalizer.MoodAnalizerClass", "MoodAnalizerClas"); ;
            }
            catch (MoodAnlyseException ex)
            {
                Assert.AreEqual("Constructor not found", ex.Message);
            }
        }
    }
}
