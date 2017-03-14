using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3Zajecia2
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

        public Osoba(string imie, string nazwisko, string dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }
        public virtual void WypiszInfo()
        {
            Console.WriteLine("Imie: {0} Nazwisko: {1}, Data Urodzenia{2}", imie, nazwisko, dataUrodzenia);
        }
    }
}
