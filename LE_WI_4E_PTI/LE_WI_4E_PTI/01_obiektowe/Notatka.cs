using System;

namespace NotatkiKonsola
{
    /************************************************
    nazwa klasy: Notatka
    opis klasy: Klasa reprezentuje pojedynczą notatkę tekstową. Przechowuje unikalny identyfikator, globalny licznik notatek, tytuł oraz treść.
    pola: licznik - pole statyczne zliczające liczbę utworzonych obiektów klasy Notatka (niewidoczne dla klas potomnych)
          identyfikator - unikalny numeryczny identyfikator notatki nadawany automatycznie (niewidoczne dla klas potomnych)
          tytul - pole tekstowe przechowujące tytuł notatki (dostępne dla klas potomnych)
          tresc - pole tekstowe przechowujące treść notatki (dostępne dla klas potomnych)
    metody: Wyswietl - metoda bezparametrowa, wyświetla tytuł i treść notatki w czytelnej formie
            Diagnostyka - metoda bezparametrowa, wypisuje wartości wszystkich pól obiektu oddzielone średnikami
    autor: Ni Wę
    ************************************************/
    public class Notatka
    {
        private static int licznik = 0;
        private int identyfikator;
        protected string tytul;
        protected string tresc;

        public Notatka(string tytul, string tresc)
        {
            licznik++;
            identyfikator = licznik;
            this.tytul = tytul;
            this.tresc = tresc;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Tytuł: {tytul}");
            Console.WriteLine($"Treść: {tresc}");
        }

        public void Diagnostyka()
        {
            Console.WriteLine($"{licznik};{identyfikator};{tytul};{tresc}");
        }
    }
}
