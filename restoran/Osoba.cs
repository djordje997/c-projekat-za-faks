using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace restoran
{
    class Osoba
    {
        private string ime;
        public Osoba(string ime)
        {
            this.ime = ime;
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
    }
}
