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
            
           if (this.message.Contains("sad"))
            {
                return "SAD";
            }
            else 
            {
                return "Not in any mood";
            }
                
                  
                
               
           
        }
    }
}
