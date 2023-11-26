using System;

namespace Zadanie2{
    class Program{
        static void Main(string[] args){
            try{
                Console.Write("Podaj wagę (w kg): ");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.Write("Podaj wzrost (w metrach): ");
                double height = Convert.ToDouble(Console.ReadLine());
                double bmi = weight / (height * height);

                Console.WriteLine($"Twoje BMI wynosi: {bmi}");
            }
            catch (FormatException ignored){
                Console.WriteLine("Wprowadzono nieprawidłowy numer");
            }
        }
    }
}