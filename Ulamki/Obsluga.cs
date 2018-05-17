using System;
using System.Security.Cryptography.X509Certificates;

namespace Ulamki
{
    public class Obsluga
    {
        public static Ulamek PobierzUlamek()
        {
            Ulamek ulamek= new Ulamek();
            bool correctness;
            Console.Write("podaj licznik:");
            ulamek.Licznik = Int32.Parse(Console.ReadLine());
            do
            {
                correctness = true;
                Console.Write("podaj mianownik:");
                try
                {
                    ulamek.Mianownik = Int32.Parse(Console.ReadLine());
                    if (ulamek.Mianownik == 0)
                    {
                        Console.WriteLine("Mianownik nie może byc równy 0.");
                        correctness = false;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Nieprawidłowy format liczby.");
                    correctness = false;
                    
                }

            } while (!correctness);

            return ulamek;

        }

        public static void WyswietlUlamek(Ulamek ulamek)
        {
            Console.WriteLine("{0}",ulamek.Licznik);
            Console.WriteLine("__");
            Console.WriteLine("{0}",ulamek.Mianownik);
        }
        
    }
}