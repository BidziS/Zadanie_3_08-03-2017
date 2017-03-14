using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3Zajecia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================OSOBA======================");
            Osoba osoba = new Osoba("Daniel", "Cudnik", "11-06-1993");
            osoba.WypiszInfo();

            Console.WriteLine("====================================================");

            Console.WriteLine("\n");

            Console.WriteLine("======================PIŁKARZE======================");

            Pilkarz pilkarz = new Pilkarz("Daniel", "Cudnik", "11-06-1993", "Bramkarz", "FC Popielno");

            Pilkarz pilkarzNozny = new PilkarzNozny("Radosław", "Cybulski", "22-02-1993", "Napastnik", "AC Babiec Rrżały");

            Pilkarz pilkarzReczny = new PilkarzReczny("Tomasz", "Zieliński", "22-02-1993", "Rozgrywający", "KS Ruciane");

            pilkarz.WypiszInfo();
            pilkarzNozny.WypiszInfo();
            pilkarzReczny.WypiszInfo();


            pilkarz.StrzelGola();
            pilkarzNozny.StrzelGola();
            pilkarzReczny.StrzelGola();

            Console.WriteLine("====================================================");

            Console.WriteLine("\n");

            Console.WriteLine("======================STUDENT======================");

            Student student = new Student("Daniel", "Cudnik", "11.06.1993", 1, 1, 123212);

            student.DodajOcene("WDP", "20.03.2017", 4.5);
            student.DodajOcene("WDP", "21.03.2017", 5);
            student.DodajOcene("ZPO", "22.03.2017", 3);
            student.DodajOcene("WDP", "23.03.2017", 2);
            student.DodajOcene("ZPO", "24.03.2017", 3.5);

            student.WypiszOceny();
            student.WypiszOceny("WDP");
            student.UsunOcene("WDP", "20.03.2017", 4.5);
            student.WypiszOceny();
            student.UsunOceny("ZPO");
            student.WypiszOceny();
            student.DodajOcene("Sieci", "23.03.2017", 2);
            student.DodajOcene("WF", "24.03.2017", 3.5);
            student.WypiszOceny();
            student.UsunOceny();
            student.WypiszOceny();

            Console.ReadLine();
        }
    }
}
