using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelve
    {

        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public List<Book> Lista;

        public Shelve(String shelve, String sector)
        {
            this.LibraryShelve = shelve;
            this.LibrarySector = sector;
            this.Lista = new List<Book>();

        }

        
        public void ShelveBook(Book libro)
        {
            this.Lista.Add(libro);
        }

        public void UnShelveBook(Book libro)
        {
            this.Lista.Remove(libro);
        }

    }
}
