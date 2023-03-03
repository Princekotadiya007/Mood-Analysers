using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
