using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
         public void TestMethodGivenDistanceAndTime_shouldReturnFare()
         {
                InvoiceGenerator invoice = new InvoiceGenerator(RideType.Normal);
                double distance = 12.0;
                int time = 10;
                double fare = invoice.CalculateFare(distance,time);
                double expected = 130;    //(12.0 * 10)+10=120+10=130
                Assert.AreEqual(expected, fare);
         }
        
    }
}