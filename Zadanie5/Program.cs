using System;

namespace Zadanie5{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Wprowadź równanie kwadratowe w postaci ax^2 + bx + c = 0 (podaj: a, b, c)");
            double a, b, c;
            try{
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ignored){
                Console.WriteLine("Wprowadzono nieprawidłową liczbę");
                return;
            }

            if (a == 0){
                Console.WriteLine("Wprowadzono wprowadzono nieprawidłowe równanie kwadratowe");
                return;
            }

            double delta = b * b - 4 * a * c;
            Console.WriteLine("Rozwiązania równania:");
            if (delta > 0){
                Console.WriteLine($"x1 = {Math.Round((-b - Math.Sqrt(delta)) / (a * 2), 2)}");
                Console.WriteLine($"x2 = {Math.Round((-b + Math.Sqrt(delta)) / (a * 2), 2)}");
                return;
            }

            if (delta == 0){
                Console.WriteLine($"x1 = {Math.Round((-b) / (a * 2), 2)}");
                return;
            }
            
            Console.WriteLine($"x1 = {formatImaginary(Math.Round((-b)/ (2 * a), 2), Math.Round((- Math.Sqrt(Math.Abs(delta)) / (a * 2)), 2))}");
            Console.WriteLine($"x2 = {formatImaginary(Math.Round((-b)/ (2 * a), 2), Math.Round((+ Math.Sqrt(Math.Abs(delta)) / (a * 2)), 2))}");
            
        }

        private static string formatImaginary(double real, double imaginary){
            if (imaginary < 0){
                return $"{real} - {Math.Abs(imaginary)}i";
            }

            if (imaginary == 0){
                return $"{real}";
            }
            return $"{real} + {Math.Abs(imaginary)}i";
        }
    }
}