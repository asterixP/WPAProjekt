using System;
using ProjektWPA.Factory;

namespace ProjektWPA
{
    class Program
    {
        static void Main(string[] args)
        {

            WyswietlanieSingleton wiadomosc = WyswietlanieSingleton.getinstance();
            wiadomosc.ustawWiadomosc("Mam smocze jaja");
            Console.WriteLine(wiadomosc.zwrocwiadomosc());

            AbsDecorator Transakcja1 = TransakcjaWytworcza.StworzTransakcja();

            Decorator1 Decorator1 = new Decorator1(Transakcja1);
            Decorator2 Decorator2 = new Decorator2(Decorator1);
            Console.WriteLine(Decorator2.setwartosc());

            OsobaPrototype p1 = new OsobaPrototype();
            p1.wiek = 18;
            p1.Dataurodzenia = Convert.ToDateTime("2004-01-01");
            p1.Imie = "Julka";
            p1.IdInfo = new IdInfoprototype(666);

            OsobaPrototype p2 = p1.lekkakopia();
            OsobaPrototype p3 = p1.glebokakopia();

            Console.WriteLine("------------- Oryginalne dane p1, p2, p3:");
            Console.WriteLine("    wartość instancji p1:   ");
            WyswietlanieDanych(p1);
            Console.WriteLine("    wartość instancji p2:   ");
            WyswietlanieDanych(p2);
            Console.WriteLine("    wartość instancji p3:    ");
            WyswietlanieDanych(p3);


            p1.wiek = 24;
            p1.Dataurodzenia = Convert.ToDateTime("1998-01-01");
            p1.Imie = "Karol";
            p1.IdInfo.IdNumber = 8787;
            Console.WriteLine("------------- Dane p1, p2, p3 po zmianach na p1:");
            Console.WriteLine("    wartość instancji p1:   ");
            WyswietlanieDanych(p1);
            Console.WriteLine("    wartość instancji p2 (po zmianie wartosci id):   ");
            WyswietlanieDanych(p2);
            Console.WriteLine("    wartość instancji p3 (wszystko bez zmian):    ");
            WyswietlanieDanych(p3);


        }

        public static void WyswietlanieDanych(OsobaPrototype p)
            {
            Console.WriteLine("     Imie: {0:s}. Wiek: {1:d}, DataUrodzenia: {2:dd/mm/yy}", p.Imie, p.wiek, p.Dataurodzenia);
            Console.WriteLine("     Id#: {0:d}", p.IdInfo.IdNumber);
            }

    }
}
