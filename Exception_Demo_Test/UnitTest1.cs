using Exception_Demo;

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


    }
}