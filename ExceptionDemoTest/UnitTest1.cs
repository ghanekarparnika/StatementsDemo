using ExceptionDemo;

namespace ExceptionDemoTest
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
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string actual = moodAnalyser.analyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //tc1.2
        [TestMethod]
        public void GivenSadMoodreturnHAPPY()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in any mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string actual = moodAnalyser.analyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenNullMoodreturnHAPPY()
        {
            //Arrange
            string expected = "HAPPY";
            string message = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string actual = moodAnalyser.analyseMood();
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GivenNullMoodShouldThrowInvalidMood()
        {
            try
            {
                //Arrange
                string expected = "Invalid Mood";
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                //Act
                string actual = moodAnalyser.analyseMood();
                
               
            }catch(MoodAnalyserException e)
            {
                //Assert
                Assert.AreEqual("Invalid Mood", e.Message);
            }

        }


        [TestMethod]
        public void GivenEmptyMoodShouldThrowInvalidMood()
        {
            try
            {
                //Arrange
                string expected = "Invalid Mood";
                string message = " ";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                //Act
                string actual = moodAnalyser.analyseMood();


            }
            catch (MoodAnalyserException e)
            {
                //Assert
                Assert.AreEqual("Invalid Mood", e.Message);
            }

        }

        [TestMethod]
        public void GivenClassNameShoulReturnObject()
        {
            object expected = new MoodAnalyser();
            object actual = MoodAnalyserFactory.CreateMoodAnalyserObject("ExceptionDemo.MoodAnalyser", "MoodAnalyser");
            expected.Equals(actual);
        }
    }
}