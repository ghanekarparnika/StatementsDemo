using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    public class MoodAnalyserFactory
    {
        

        public static Object CreateMoodAnalyserObject(string className, string constructor)
        {
            try
            {
                string classname = "Exception_Demo.Mood_Analyser";
                string constructorname = "Mood_Analyser";
                if (classname != className)
                {
                    throw new MoodAnalys_Exception(MoodAnalys_Exception.ExceptionType.NO_SUCHCLASS, "no class found");
                }
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type moodAnalyserType = assembly.GetType(className);
                return Activator.CreateInstance(moodAnalyserType);
            }
            catch (MoodAnalys_Exception e)
            {
                return e.Message;
            }

           
        }
    }
}
