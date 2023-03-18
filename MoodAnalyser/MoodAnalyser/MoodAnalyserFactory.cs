using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static MoodAnalyser.MoodAnlyseException;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        //Method to create Mood Analyser Object Using Reflection
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            //Matching the pattern for extension of namespace
            string pattern = @"." + constructorName + "$";
            bool result = Regex.IsMatch(pattern, className);
            if (result)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type MoodAnalyzerType = executing.GetType(className);
                    return Activator.CreateInstance(MoodAnalyzerType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnlyseException(MoodAnlyseException.MoodAnlyseExceptionType.NO_SUCH_CLASS, "Class not found");

                }
            }
            else
            {
                throw new MoodAnlyseException(MoodAnlyseException.MoodAnlyseExceptionType.NO_SUCH_METHOD, "Constructor not found");
            }
        }
    }
}
