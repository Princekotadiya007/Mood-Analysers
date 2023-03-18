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
            EmptyMood,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD
        }
        public MoodAnlyseExceptionType Type;
        public MoodAnlyseException(MoodAnlyseExceptionType Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }
}
