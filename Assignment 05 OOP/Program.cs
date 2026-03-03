using Assignment_04_OOP.BookingTicket.Inheritance;
using Assignment_05_OOP.Interfaces;
using System;

namespace Assignment_05_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region PART 01
            //    PART 01 :




            //        Question 01 :

            //               // An interface defines a contract that a class must follow. It specifies what a class can do, not how it does it.



            //              // Because interfaces allow us to depend on abstractions instead of specific implementations.



            //              // Enable polymorphism without inheritance , Remove tight coupling between classes , Enable multiple inheritance(behavior)





            //        Question 02 :

            //                 a)  Method Name Conflict  ,,,,    Both IEnglishSpeaker.Greet() and IArabicSpeaker.Greet()  do the exact same thing — we can't give them different behavior! ,,,


            //                     Solution: Explicit Implementation  .



            //                b) by way  Each interface has its own behavior

            //                    means implementing interface members in a way that they are accessible only through the interface reference.


            //                   Explicit Implementation.



            //                c)  Explicit members are hidden from the class reference. You must cast to the interface first ,,,



            //                    Translator t1 = new Translator();

            //IEnglishSpeaker e = t1;

            //e.Greet();


            //                    IArabicSpeaker a = t1;

            //a.Greet();





            //     Question 03 :



            //             Shallow copy : A shallow copy copies the object but copies references for reference-type fields.


            //            Deep copy : A deep copy copies the object and all nested objects, creating fully independent duplicates. 




            //                 When to use :


            //                            Shallow → object is immutable, no nested reference state, performance is critical

            //                            Deep → objects must be isolated, modifications should not affect original



            //                 Risk: Two objects, same inner references Changing inner object affects both copies





            //     Question 04 :


            //                 Dev - Testing
            //                 QA - Testing 
            #endregion



            Cinema c1  = new Cinema();
            c1.OpenCinema();


            StandardTicket t1 = new StandardTicket("Inception", 80, "A5");

            VIPTicket t2 = new VIPTicket("Avengers", 200, true);

            IMAXTicket t3 = new IMAXTicket("Dune", 130, true);



            t1.book();

            t2.book();

            t3.book();


            c1.AddTicket(t1);

            c1.AddTicket(t2);

            c1.AddTicket(t3);

            c1.PrintAllTickets();


            Console.WriteLine("\n--- Clone Test ---");


            VIPTicket clone = (VIPTicket)t2.Clone();
            clone.MovieName = "Interstellar";


            Console.Write("Original : ");
            t2.print();

            Console.Write("Clone    : ");
            clone.print();

            
            Console.WriteLine("\n--- After Cancellation ---");
            t1.cancele();
            t1.print();

            
            BookingHelper.PrintAll(new IPrintable[] { t1, t2, t3 });

            c1.CloseCinema();
        












    }

        static class BookingHelper
        {
            public static void PrintAll(IPrintable[] items)
            {
                Console.WriteLine("\n--- BookingHelper.PrintAll ---");

                foreach (var item in items)
                {
                    item.print();
                }
            }
        }




    }
}
