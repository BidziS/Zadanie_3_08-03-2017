using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3Zajecia2
{
    class PilkarzNozny : Pilkarz
    {
        public PilkarzNozny(string imie, string nazwisko, string dataUrodzenia, string klub, string pozycja) : base(imie, nazwisko, dataUrodzenia, klub, pozycja)
        {
        }
        public override void StrzelGola()
        {
            Console.WriteLine("Piłkarz nożny {0} strzela gola.", imie);
            LiczbaGoli++;
        }

    }
}
