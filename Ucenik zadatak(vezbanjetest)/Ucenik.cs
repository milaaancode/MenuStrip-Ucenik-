using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenik_zadatak_vezbanjetest_
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }

        public Ucenik(string Ime, string Prezime, string Telefon)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.Telefon = Telefon;
        }
    }
}
