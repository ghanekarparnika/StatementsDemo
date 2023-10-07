using Exception_Demo;

namespace Exception_Demo_Test
{
    [TestClass]
    public class UnitTest1
    {

        //tc1.1
        [TestMethod]
        public void GivenSadMoodreturnSAD()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in sad mood";
            MoodAnalyser mood = new MoodAnalyser(); 
            //Act
            string actual = mood.analyseMood(message);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //tc1.2
        [TestMethod]
        public void GivenAnyMoodreturnHAPPY()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in any mood";
            MoodAnalyser mood = new MoodAnalyser();
            //Act
            string actual = mood.analyseMood(message);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}