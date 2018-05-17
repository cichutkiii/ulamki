using System;

namespace Ulamki
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            bool exit = false;
            int n;
            Ulamek ulamek = new Ulamek();
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Skróć ułamek");
                Console.WriteLine("2. Odwróć ułamek");
                Console.WriteLine("3. Zamień na ulamek dziesiętny");
                Console.WriteLine("4. Zamień na ułamek zwykły");
                Console.WriteLine("5. Dodaj ułamki");
                Console.WriteLine("6. Odejmij ułamki");
                Console.WriteLine("7. Wyjdź");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                    {
                        ulamek = Obsluga.PobierzUlamek(); 
                        Dzialania.Skracanie(ulamek);
                        break;
                    }
                    case 2:
                    {
                        ulamek = Obsluga.PobierzUlamek();
                        Ulamek odwroconyUlamek = new Ulamek();
                        odwroconyUlamek = Dzialania.Odwracanie(ulamek);
                        Console.WriteLine("Ułamek do odwrócenia");
                        Obsluga.WyswietlUlamek(ulamek);
                        Console.WriteLine("Ułamek odwrocony");
                        Obsluga.WyswietlUlamek(odwroconyUlamek);
                        
                        
                        break;
                    }
                    case 3:
                    {
                        ulamek = Obsluga.PobierzUlamek();
                        Console.WriteLine("Ulamek zwykly:");
                        Obsluga.WyswietlUlamek(ulamek);
                        Dzialania.UlamekDziesietny(ulamek);
                        break;
                    }
                    case 4:
                    {                        
                        Console.WriteLine("Podaj ułamek dziesiętny (do 3 miejsc po przecinku):");
                        Ulamek ulamekZwykly = new Ulamek();
                        ulamekZwykly = Dzialania.UlamekZwykly();
                        Dzialania.Skracanie(ulamekZwykly, true);

                        break;
                    }
                    case 5:
                    {
                        Dzialania.DodajUlamki();
                        break;
                    }
                    case 6:
                    {
                        
                        break;
                    }
                    case 7:
                    {
                        exit = true;

                        break;
                    }
                    default:
                    {
                        Console.WriteLine("nie ma takiej opcji");
                        break;
                    }


                }
            } while (!exit);
            
            
        }
    }
}