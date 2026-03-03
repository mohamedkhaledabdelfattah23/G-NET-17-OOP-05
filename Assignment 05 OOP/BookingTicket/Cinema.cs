using Assignment_05_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP.BookingTicket.Inheritance
{
    internal class Cinema
    {

        private IPrintable[] tickets = new IPrintable[20];
        

        public void AddTicket(IPrintable t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    break;
                }
            }
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n--- All Tickets ---");

            foreach (var t in tickets)
            {
                if (t != null)
                    t.print(); 
            }
        }

        public void OpenCinema()
        {
            Console.WriteLine("=== Cinema Opened ===");

        }

        public void CloseCinema()
        {
            Console.WriteLine("\n=== Cinema Closed ===");

        }




    }
}
