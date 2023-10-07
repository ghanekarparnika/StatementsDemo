using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    public class MoodAnalyser
    {

        public string analyseMood(string message)
        {
            
           if (message.Contains("sad"))
            {
                return "SAD";
            }
            else 
            {
                return "I am Not in sad mood";
            }
                
                  
                
               
           
        }
    }
}
