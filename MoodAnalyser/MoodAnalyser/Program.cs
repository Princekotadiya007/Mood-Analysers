using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyzerProblem mood = new MoodAnalyzerProblem(null);
            Console.WriteLine(mood.AnalyzeeMood());
            Console.ReadLine();
        }
    }
}
