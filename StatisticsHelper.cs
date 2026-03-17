using System;

namespace MyNamespace
{
    class StatisticsHelper
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Podaj liczby po spacji");
            string liczby = System.Console.ReadLine();

            System.Console.WriteLine($"Twoje liczby to: ${liczby}");

            Console.WriteLine("Mnożenie");

            Console.Write("Podaj pierwszą liczbę: ");

            string input1 = Console.ReadLine();

            if (!double.TryParse(input1, out double liczba1))
            {
                Console.WriteLine("Błąd podczas wprowadzania liczby");
                return;
            }

            Console.Write("Podaj drugą liczbę: ");

            string input2 = Console.ReadLine();

            if (!double.TryParse(input2, out double liczba2))
            {
                Console.WriteLine("Błąd podczas wprowadzania liczby");
                return;
            }

            Console.WriteLine("\n--- Wyniki ---");

            double mnozenie = liczba1 * liczba2;
            Console.WriteLine($"Mnożenie: {liczba1} * {liczba2} = {mnozenie}");
            
            //Dzielenie
        }
    }
}