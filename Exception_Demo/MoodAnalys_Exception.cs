using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    public class MoodAnalys_Exception : Exception
    {
      public enum ExceptionType
        {
            NULL_MESSAGE,EMPTY_MESSAGE,NO_SUCH_CLASS,NO_FOUND_CONSTRUCTOR
        }

        public ExceptionType type;
        public MoodAnalys_Exception(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
