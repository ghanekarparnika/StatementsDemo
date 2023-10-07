using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    public class MoodAnalyser
    {

        private string message;

        public MoodAnalyser() { }
        public MoodAnalyser(string message) 
        {
            this.message = message;
        }

        public string analyseMood()
        {
            try
            { 
            
                if(this.message.Equals(null))
                {
                    throw new MoodAnalys_Exception(MoodAnalys_Exception.ExceptionType.NULL_MESSAGE,"Message should not be null");
                }

                if(this.message.Equals(" "))
                {
                    throw new MoodAnalys_Exception(MoodAnalys_Exception.ExceptionType.EMPTY_MESSAGE, "message should not be empty");
                }

                if (this.message.Contains("sad"))
                    {
                        return "SAD";

                    }
                    else
                    {
                        return "HAPPY";
                    }
               
             }catch (MoodAnalys_Exception ex) 
            {
                return ex.Message;
            }






        }
    }
}
