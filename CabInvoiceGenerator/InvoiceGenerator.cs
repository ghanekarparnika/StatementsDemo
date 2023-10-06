using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator 
    {
        //Variable
        RideType rideType;
        private RideRepository rideRepository;

        /*   //Constants
           private readonly double MINIMUM_COST_PER_KM;
           private readonly int COST_PER_TIME;
           private readonly double MINIMUM_FARE;
           int NormCount;
           int PremiCount;

           /// <summary>
           /// Constructor to Create RideRepository instance
           /// </summary>

            public InvoiceGenerator(RideType rideType)
            {
                this.rideType = rideType;
                this.rideRepository = new RideRepository();
                try
                {
                    //If the Ride Type is Premium then Rates for Premium else for Normal  
                    if (rideType.Equals(RideType.Premium))
                    {
                        this.MINIMUM_COST_PER_KM = 15;
                        this.COST_PER_TIME = 2;
                        this.MINIMUM_FARE = 20;
                    }
                    else if (rideType.Equals(RideType.Normal))
                    {
                        this.MINIMUM_COST_PER_KM = 10;
                        this.COST_PER_TIME = 1;
                        this.MINIMUM_FARE = 5;
                    }

                }
                catch (CabInvoiceException)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.Invalid_Ride_Type, "Invalid ride type");
                }
            }





               //Function to Calculate Fare
               public double CalculateFare(double distance, int time)
           {
               double totalFare = 0;
               try
               {
                   //Calculating Total Fare
                   totalFare = distance * MINIMUM_COST_PER_KM + time * COST_PER_TIME;
               }
               catch (CabInvoiceException)
               {
                   if (rideType.Equals(null))
                   {
                       throw new CabInvoiceException(CabInvoiceException.ExceptionType.Invalid_Ride_Type, "Invalid ride type");
                   }
                   if (distance <= 0)
                   {
                       throw new CabInvoiceException(CabInvoiceException.ExceptionType.Invalid_Diatance, "Invalid distance");
                   }
                   if (time < 0)
                   {
                       throw new CabInvoiceException(CabInvoiceException.ExceptionType.Invalid_Time, "Invalid time");

                   }
               }


             return Math.Max(totalFare, MINIMUM_FARE);
           }*/
        /** Constant variables. **/
        public readonly double COST_PER_KILOMETER = 10.0;
        public readonly int COST_PER_MINUTE = 1;
        public readonly double MINIMUM_FARE = 5;

        /** Calculating fare method. **/
        public double calculateFare(double distance, int time)
        {
            double totalFare = distance * COST_PER_KILOMETER + time * COST_PER_MINUTE;
            return Math.Max(totalFare, MINIMUM_FARE);
        }

        /*** Calculate fare for multiple rides. ***/
        public InvoiceSummary calculateFare(Ride[] rides)
        {
            double totalFare = 0;

            foreach (Ride ride in rides)
            {
                totalFare += this.calculateFare(ride.distance, ride.time);
            }
            return new InvoiceSummary(rides.Length, totalFare);
        }





    }




}
