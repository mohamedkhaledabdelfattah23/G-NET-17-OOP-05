using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP.BookingTicket.Inheritance
{
    internal class IMAXTicket : Ticket
    {

        public bool Is3D { get; set; }

        public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, is3D ? price + 30 : price)
        {
            Is3D = is3D;

            if (Is3D)
                price += 30;
        }

        public override void print()
        {
            Console.WriteLine(
                       $"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | " +
                       $"Price: {Price} | After Tax: {PriceAfterTax:F1} | " +
                       $"Booked: {(Isbooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new IMAXTicket( MovieName, Price, Is3D );
        }



    }
}
