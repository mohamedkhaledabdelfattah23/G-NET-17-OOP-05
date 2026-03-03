using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP.BookingTicket.Inheritance
{
    internal class StandardTicket : Ticket
    {


        public string seatNumber { get; set; }
        public StandardTicket(string movieName, decimal price, string seat) : base(movieName, price)
        {
            seatNumber = seat;

        }


        public override void print()
        {
            Console.WriteLine(

            $"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {seatNumber} | " +
            $"Price: {Price} | After Tax: {PriceAfterTax:F1} | Booked: {(Isbooked ? "Yes" : "No")}");
        }


        public override object Clone()
        {
            return new StandardTicket(  MovieName , Price  , seatNumber);
        }




      

    }
}
