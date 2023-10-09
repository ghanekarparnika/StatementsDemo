using Exception_Demo;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace Exception_Demo_Test
{
    [TestClass]
    public class UnitTest1
    {

        //tc1.1
        //refactor1-tc1.1
        [TestMethod]
        public void GivenSadMoodreturnSAD()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in sad mood";
            MoodAnalyser mood = new MoodAnalyser(message); 
            //Act
            string actual = mood.analyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //tc1.2
        //refactor1-tc1.2
        [TestMethod]
        public void GivenAnyMoodreturnHAPPY()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in any mood";
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string actual = mood.analyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //tc-2.1
        [TestMethod]
        public void GivenNullMoodreturnHAPPY()
        {
            //Arrange
            string expected = "HAPPY";
            string message = null;
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string actual = mood.analyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //tc-3.1
        [TestMethod]
        public void GivenNullMoodShouldThrowMoodAnalyseException()
        {
            //Arrange
            string expected = "HAPPY";
            string message = null;
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string actual = mood.analyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //TC3.2
        [TestMethod]
        public void GivenEmptyMoodShouldThrowMoodAnalyseException()
        {
            //Arrange
            string expected = "message should not be empty";
            string message =" ";
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string actual = mood.analyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        //TC4.1
        [TestMethod]
        public void ReturnObjectByUsingReflection()
        {
            //Arrange
            Object expected =new MoodAnalyser();
           
            //Act
            Object createdobj = MoodAnalyserFactory.CreateMoodAnalyserObject("Exception_Demo.MoodAnalyser", "MoodAnalyser");
   
            //Assert
           expected.Equals(createdobj);
            
        }

        //TC4.2
        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalyserException()
        {
            //Arrange
            Object expected = new MoodAnalyser();

            //Act
            Object createdobj = MoodAnalyserFactory.CreateMoodAnalyserObject("Exception_Dem.MoodAnalyser", "MoodAnalyser");

            //Assert
            expected.Equals(createdobj);
            Console.WriteLine(createdobj.ToString());

        }

        //TC4.3
        [TestMethod]
        public void GivenImproperConstructorNameShouldThrowMoodAnalyserException()
        {
            //Arrange
            Object expected = new MoodAnalyser();

            //Act
            Object createdobj = MoodAnalyserFactory.CreateMoodAnalyserObject("Exception_Demo.MoodAnalyser", "MooodAnalyser");

            //Assert
            expected.Equals(createdobj);
            Console.WriteLine(createdobj.ToString());

        }

        //TC5.1
        [TestMethod]
        public void ReturnObjectByUsingReflectionParameterizedConstructor()
        {
            //Arrange
            string message = "I am in any mood";
            Object expected = new MoodAnalyser(message);

            //Act
            Object createdobj = MoodAnalyserFactory.CreateMoodAnalyserObjectWithParameterizedConstructor("Exception_Demo.MoodAnalyser", "MoodAnalyser(message)");

            //Assert
            expected.Equals(createdobj);

            Type typeofcreatedobj= createdobj.GetType();
            Console.WriteLine(typeofcreatedobj);

            /*Type type = Type.GetType("created");
            type.ToString();
            Console.WriteLine(type);
*/
        }

        //TC5.2
        [TestMethod]
        public void ImproperClassNameShouldThrowExceptionParameterizedConstructor()
        {
            //Arrange
            string message = "I am in any mood";
            Object expected = new MoodAnalyser(message);

            //Act
            //Passing wrong name
            Object createdobj = MoodAnalyserFactory.CreateMoodAnalyserObjectWithParameterizedConstructor("Exception_Demoo.MoodAnalyser", "MoodAnalyser(message)");

            //Assert
            expected.Equals(createdobj);

            Type typeofcreatedobj = createdobj.GetType();
            Console.WriteLine(typeofcreatedobj);
            Console.WriteLine(createdobj.ToString());


        }

        //TC5.3
        [TestMethod]
        public void ImproperConstructorNameShouldThrowExceptionParameterizedConstructor()
        {
            //Arrange
            string message = "I am in any mood";
            Object expected = new MoodAnalyser(message);

            //Act
            //Passing wrong name
            Object createdobj = MoodAnalyserFactory.CreateMoodAnalyserObjectWithParameterizedConstructor("Exception_Demo.MoodAnalyser", "MoodAnalySer(message)");

            //Assert
            expected.Equals(createdobj);

            Type typeofcreatedobj = createdobj.GetType();
            Console.WriteLine(typeofcreatedobj);
            Console.WriteLine(createdobj.ToString());


        }

        //TC6.1
        [TestMethod]
        public void Invoke_Method_Using_Reflection()
        {
            //Arrange
            string message = "I am in any mood";
            string expected = "HAPPY";

            //Act
            //Passing wrong name
          
                string output = MoodAnalyserFactory.InvokeMethodWithReflection("Exception_Demo.MoodAnalyser",message);

                //Assert
                Assert.AreEqual(expected, output);
            Console.WriteLine(output);
          


        }



    }
}