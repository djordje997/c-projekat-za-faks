using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace restoran
{
    class Gost : Osoba
    {
        private double racun;
        public Gost(string s, double racun) : base(s)
        {
            this.racun = racun;
        }
        public void UpisiRacun(string poruceno, string komada, string ime)
        {
            StreamWriter wr = new StreamWriter(@"racun.txt", true);
            wr.WriteLine("Gost : " + base.Ime + ". Vas racun iznosi: " + racun + ". Porucili ste : " + poruceno + ", " + komada + " porcije. Hvala sto koristite nase usluge!");
            wr.Close();
        }
    }
}
