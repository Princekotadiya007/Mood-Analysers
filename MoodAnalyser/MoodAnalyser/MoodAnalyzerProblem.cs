using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyser.MoodAnlyseException;

namespace MoodAnalyser
{
    public class MoodAnalyzerProblem
    {
        string message;
        public MoodAnalyzerProblem(string message)
        {
            this.message = message;
        }
        public string AnalyzeeMood()
        {
            try
            {
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
           
            catch (NullReferenceException)
            {
                throw new MoodAnlyseException(MoodAnlyseExceptionType.NullMood, "Please do not Enter the Null Input");
            }
        }
    }
}
