using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnlyseException : Exception
    {
        public enum MoodAnlyseExceptionType
        {
            NullMood,
        }
        public MoodAnlyseExceptionType Type;
        public MoodAnlyseException(MoodAnlyseExceptionType Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }
}
