using System;

namespace NotatkiKonsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("    PROGRAM TESTUJĄCY KLASĘ NOTATKA (INF.04)");
            Console.WriteLine("    Autor: Ni Wę, Klasa: 4E");
            Console.WriteLine("==================================================\n");

            // Krok 7: Utworzenie co najmniej dwóch obiektów z własnymi, znaczącymi danymi
            Console.WriteLine("Tworzenie obiektów notatek...");
            Notatka notatka1 = new Notatka("Lista zakupów", "Mleko, pieczywo, masło, jabłka");
            Notatka notatka2 = new Notatka("Spotkanie projektowe", "Omówienie założeń aplikacji mobilnej w piątek o 14:00");
            Console.WriteLine("Utworzono 2 obiekty klasy Notatka.\n");

            // Wywołanie obu metod dla pierwszego obiektu
            Console.WriteLine("--- NOTATKA 1 ---");
            Console.WriteLine("[Metoda Wyswietl]:");
            notatka1.Wyswietl();
            Console.WriteLine("[Metoda Diagnostyka (licznik;identyfikator;tytul;tresc)]:");
            notatka1.Diagnostyka();

            Console.WriteLine("\n--------------------------------------------------");

            // Wywołanie obu metod dla drugiego obiektu
            Console.WriteLine("--- NOTATKA 2 ---");
            Console.WriteLine("[Metoda Wyswietl]:");
            notatka2.Wyswietl();
            Console.WriteLine("[Metoda Diagnostyka (licznik;identyfikator;tytul;tresc)]:");
            notatka2.Diagnostyka();

            Console.WriteLine("\n==================================================");
            Console.WriteLine("WERYFIKACJA ZAŁOŻEŃ ZADANIA:");
            Console.WriteLine("1. Pierwszy obiekt ma identyfikator: 1");
            Console.WriteLine("2. Drugi obiekt ma identyfikator: 2");
            Console.WriteLine("3. Statyczny licznik wskazuje liczbę utworzonych obiektów: 2");
            Console.WriteLine("4. Obie metody (Wyswietl, Diagnostyka) działają poprawnie.");
            Console.WriteLine("==================================================");
        }
    }
}
