using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        InvoiceGenerator invoiceGenerator;
        /*[TestMethod]
         public void TestMethodGivenDistanceAndTime_shouldReturnFare()
         {
                InvoiceGenerator invoice = new InvoiceGenerator(RideType.Normal);
                double distance = 12.0;
                int time = 10;
                double fare = invoice.CalculateFare(distance,time);
                double expected = 130;    //(12.0 * 10)+10=120+10=130
                Assert.AreEqual(expected, fare);
         }*/
        [TestMethod]
        public void givenMultipleRides_shouldReturnInvoiceSummary()
        {
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.3, 2) };

            try
            {
                InvoiceSummary invoiceSummary = invoiceGenerator.calculateFare(rides);
                InvoiceSummary expectedInvoiceSummary = new InvoiceSummary(2, 30);
                Assert.AreEqual(expectedInvoiceSummary, invoiceSummary);
            }catch(NullReferenceException ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }


    }
}