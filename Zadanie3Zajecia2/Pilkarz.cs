using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3Zajecia2
{
    class Pilkarz:Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;

        protected int LiczbaGoli
        {
            get
            {
                return liczbaGoli;
            }

            set
            {
                liczbaGoli = value;
            }
        }

        public Pilkarz(string imie, string nazwisko, string dataUrodzenia, string klub, string pozycja) : base(imie, nazwisko, dataUrodzenia)
        {
            this.pozycja = pozycja;
            this.klub = klub;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Imie: {0} Nazwisko: {1}, Data Urodzenia{2}", imie, nazwisko, dataUrodzenia);
        }
        virtual public void StrzelGola()
        {
            Console.WriteLine("Piłkarz {0} strzela gola.", imie);
            LiczbaGoli++;
        }


    }
}
