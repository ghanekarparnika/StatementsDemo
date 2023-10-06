using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        private int NUMBER_OF_RIDES;
        private double TOTAL_FARE;
        private double AVERAGE_FARE;

        public InvoiceSummary(int NUMBER_OF_RIDES, double TOTAL_FARE) 
        {
            this.NUMBER_OF_RIDES = NUMBER_OF_RIDES;
            this.TOTAL_FARE = TOTAL_FARE;
            this.AVERAGE_FARE = this.TOTAL_FARE / this.NUMBER_OF_RIDES;

        }

        public override bool Equals(object? obj)
        {
            if (obj == null) 
                return false;
            if (!(obj is InvoiceSummary))
                return false;
            InvoiceSummary inputObject = (InvoiceSummary)obj;
            return this.NUMBER_OF_RIDES == inputObject.NUMBER_OF_RIDES && this.TOTAL_FARE == inputObject.TOTAL_FARE && this.AVERAGE_FARE == inputObject.AVERAGE_FARE;


        }
    }
}
