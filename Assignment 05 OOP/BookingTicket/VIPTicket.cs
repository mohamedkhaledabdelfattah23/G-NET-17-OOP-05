using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP.BookingTicket.Inheritance
{
    internal class VIPTicket : Ticket

    {
        public bool LoungeAccess { get; set; }

        public decimal ServiceFee { get; } = 50;
        public VIPTicket(string movieName, decimal price, bool louAccs) : base(movieName, price + 50)
        {

            LoungeAccess = louAccs;
        }

        public override void print()
        {
            Console.WriteLine(
                   $"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | " +
                   $"Fee: {ServiceFee} | Price: {Price} | After Tax: {PriceAfterTax:F1} | " +
                   $"Booked: {(Isbooked ? "Yes" : "No")}"
             );
        }


        public override object Clone()
        {
            return new VIPTicket( MovieName , Price , LoungeAccess);
        }


    }
}
