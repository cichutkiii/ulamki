using System;

namespace Ulamki
{
    public class Dzialania
    {
         public static void Skracanie(Ulamek ulamek, bool pojWynik = false)
        {

            int dzielnik;
            Ulamek wynik = new Ulamek();
            
            dzielnik = NWD(ulamek.Licznik, ulamek.Mianownik);
            if (dzielnik == 1)
            {
                Console.WriteLine("Ułamek nie jest skracalny");
               
                    Obsluga.WyswietlUlamek(ulamek);
                
            }
            else
            {
                wynik.Licznik = ulamek.Licznik / dzielnik;
                wynik.Mianownik = ulamek.Mianownik / dzielnik;
                Console.WriteLine("{0}\t\t{1}",ulamek.Licznik,wynik.Licznik);
                Console.WriteLine("__\t=\t__");
                Console.WriteLine("{0}\t\t{1}",ulamek.Mianownik,wynik.Mianownik);
            }

           
               
            
            

        }

        public static int NWD(int a, int b)
        {
            int temp;
            if (b > a)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (b == 0)
                return a;
            else
                return  NWD(b, a % b);
        }

        public static Ulamek Odwracanie(Ulamek ulamek)
        {
            Ulamek odwrocony = new Ulamek();
            odwrocony.Licznik = ulamek.Mianownik;
            odwrocony.Mianownik = ulamek.Licznik;
            return odwrocony;
        }

        public static void UlamekDziesietny(Ulamek ulamek)
        {
            double ulamekDziesietny = (Double) ulamek.Licznik / (double) ulamek.Mianownik;
            
            Console.WriteLine("ulamek dziesietny:");
            Console.WriteLine(Math.Round(ulamekDziesietny, 3).ToString());
        }

        public static Ulamek UlamekZwykly()
        {
            string number;
            int ilePoPrzecinku;
            double ulamekDziesietny;
            Ulamek ulamekZwykly = new Ulamek();
            number = Console.ReadLine();
            ilePoPrzecinku = number.Substring(number.IndexOf(",")+1).Length;
            ulamekDziesietny = Double.Parse(number);
            ulamekZwykly.Mianownik = (int) Math.Pow(10,ilePoPrzecinku);
            ulamekDziesietny = ulamekDziesietny * ulamekZwykly.Mianownik;
            ulamekZwykly.Licznik = (int) ulamekDziesietny;

            return ulamekZwykly;
        }

        public static void DodajUlamki()
        {
            Ulamek u1 = new Ulamek();
            Ulamek u2 = new Ulamek();
            Console.WriteLine("pobierz pierwszy Ułamek");
            u1 = Obsluga.PobierzUlamek();
            Console.WriteLine("pobierz drugi Ułamek");
            u2 = Obsluga.PobierzUlamek();
            Console.WriteLine("Suma ułamków:\n");
            
            Obsluga.WyswietlUlamek(u1+u2);
            
        }
        
        public static void OdejmijUlamki()
        {
            Ulamek u1 = new Ulamek();
            Ulamek u2 = new Ulamek();
            Console.WriteLine("pobierz pierwszy Ułamek");
            u1 = Obsluga.PobierzUlamek();
            Console.WriteLine("pobierz drugi Ułamek");
            u2 = Obsluga.PobierzUlamek();
            Console.WriteLine("Różnica ułamków:\n");
            
            Obsluga.WyswietlUlamek(u1-u2);
            
        }
        
        
    }
}