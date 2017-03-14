using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3Zajecia2
{
    class Student:Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;

        private List<Ocena> oceny = new List<Ocena>();

        public Student(string imie, string nazwisko, string dataUrodzenia, int rok, int grupa, int nrIndeksu) : base(imie, nazwisko, dataUrodzenia)
        {
            this.rok = rok;
            this.grupa = grupa;
            this.nrIndeksu = nrIndeksu;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Imie: {0} Nazwisko: {1}, Data Urodzenia: {2} Rok: {3} Grupa: {4} NrIndeksu: {5}", imie, nazwisko, dataUrodzenia, rok, grupa, nrIndeksu);
        }
        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            oceny.Add(new Ocena(nazwaPrzedmiotu, data, wartosc));
        }
        public void WypiszOceny()
        {
            foreach (var ocena in oceny)
            {
                ocena.WypiszInfo();
            }
            Console.WriteLine();
            if (oceny.Count == 0)
            {
                Console.WriteLine("Nie ma ocen!");
            }
            Console.WriteLine("-----------------------------------------------------");

        }
        public void WypiszOceny(string nazwaPrzedmiotu)
        {
            var ocenyZDanegoPrzedmiotu = oceny.Where(ocena => ocena.NazwaPrzedmiotu == nazwaPrzedmiotu).ToList();
            foreach (var ocena in ocenyZDanegoPrzedmiotu)
            {
                ocena.WypiszInfo();
            }
            Console.WriteLine("-----------------------------------------------------");
        }
        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            var ocenaDoUsuniecia = oceny.Single(ocena => ocena.NazwaPrzedmiotu == nazwaPrzedmiotu && ocena.Data == data && ocena.Wartosc == wartosc);
            oceny.Remove(ocenaDoUsuniecia);
        }
        public void UsunOceny()
        {
            oceny.Clear();
        }
        public void UsunOceny(string nazwaPrzedmiotu)
        {
            var ocenyDoUsuniecia =  oceny.Where(ocena => ocena.NazwaPrzedmiotu == nazwaPrzedmiotu).ToList();
            foreach (var ocenaDoUsuniecia in ocenyDoUsuniecia)
            {
                oceny.Remove(ocenaDoUsuniecia);
            }
        }
    }
}
