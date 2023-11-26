using System;
using System.Diagnostics;

namespace Zadanie10{
    class Program{
        static void Main(string[] args){
            int inside = 0;
            int tries;
            Console.Write("Podaj, ile razy ma zostac wygenerowany numer: ");
            try{
                tries = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ignored){
                Console.WriteLine("Wprowadzono nieprawidłową liczbę");
                return;
            }

            Random random = new Random();
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < tries; i++){
                double x = random.NextDouble(), y = random.NextDouble();
                if (x * x + y * y <= 1){
                    inside++;
                }
            }
            float piQuarter = inside / (float) tries;
            Console.WriteLine($"PI to około {piQuarter * 4}");
            Console.WriteLine($"Obliczenia zajely {stopwatch.ElapsedMilliseconds} milisekund");
        }
    }
}