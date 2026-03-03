using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05_OOP.Interfaces
{
    internal interface IBookable
    {
        bool book();
        bool cancele();
        bool Isbooked {  get; }



    }
}
