namespace Ulamki    
{
    public class Ulamek
    {
        private int mianownik,licznik;

        public int Licznik
        {
            get => licznik;
            set => licznik = value;
        }

        public int Mianownik
        {
            get => mianownik;
            set => mianownik = value;
        }
        public static Ulamek operator+(Ulamek u1,Ulamek u2)
        {
            int mianownik;
            Ulamek wynik = new Ulamek();
            
            mianownik = u1.Mianownik;
            u1.Licznik *= u2.Mianownik;
            u1.Mianownik *= u2.Mianownik;
            u2.Licznik *= mianownik;
            u2.Mianownik *= mianownik;
            wynik.Licznik = u1.Licznik + u2.Licznik;
            wynik.Mianownik = u1.Mianownik;
            return wynik;
        }
        
        public static Ulamek operator-(Ulamek u1,Ulamek u2)
        {
            int mianownik;
            Ulamek wynik = new Ulamek();
            
            mianownik = u1.Mianownik;
            u1.Licznik *= u2.Mianownik;
            u1.Mianownik *= u2.Mianownik;
            u2.Licznik *= mianownik;
            u2.Mianownik *= mianownik;
            wynik.Licznik = u1.Licznik - u2.Licznik;
            wynik.Mianownik = u1.Mianownik;
            return wynik;
        }
    }
}