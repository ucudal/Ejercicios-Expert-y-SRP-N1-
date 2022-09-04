using System;
using System.Collections.Generic;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Shelve estanteria1= new Shelve("A","7");
            Shelve estanteria2= new Shelve("B","3");
            estanteria1.ShelveBook(book1);
            estanteria2.ShelveBook(book2);

        }
    }
}