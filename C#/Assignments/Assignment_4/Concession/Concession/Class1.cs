using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class TicketConcession
    {
        const int TotalFare = 1000;
        //Method to calculate concession based on age entered by User
        public void CalculateConcession(int age, string name)
        {
            if (age <= 5)
            {
                Console.WriteLine($"Little Champs- Free Ticket for {name}, Age {age}");
            }
            else if (age > 60)
            {
                //Calculating concession amount for Senior citizens

                double concessionAmount = 0.3 * TotalFare;
                double discountedFare = TotalFare - concessionAmount;
                Console.WriteLine($"Senior Citizen - Fare: {discountedFare} for {name}, Age {age}");
            }
            else
            {
                //Displaying message for Regular Ticket Booking
                Console.WriteLine($"Ticket Booked” - Fare: {TotalFare} for {name}, Age {age} ");
            }
        }
    }
}
