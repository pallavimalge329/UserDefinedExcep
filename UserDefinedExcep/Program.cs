using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExcep
{
    class Calculate
    {
        int total = 20;
        int ticket = 21;

        public void BookTicket(params int[] values)
        {
            //count = values.Length;

            if (ticket > 20)
            {
                throw (new CountIsZeroException("Tickets are not available for booking Ticket, Try again!!!"));
            }
            else
            {
                Console.WriteLine("Ticket Booking Confirmed! ");
            }

        }
    }

    public class CountIsZeroException : ApplicationException
    {
        public CountIsZeroException(string message) : base(message)
        {

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Handling User Defined Exception ");
            Calculate calc = new Calculate();

            try
            {
                calc.BookTicket();
            }
            catch (CountIsZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            Console.ReadKey();
        }
    }
}


