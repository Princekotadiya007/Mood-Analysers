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
                string message = null;
                object expected = new MoodAnalyzerProblem(message);
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzerProblem.MoodAnlyseException", "MoodAnalyzerProblem");
                expected.Equals(obj);
            }  
            catch (MoodAnlyseException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
