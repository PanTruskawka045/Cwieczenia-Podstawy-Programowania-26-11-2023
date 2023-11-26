using System;
using System.Collections.Generic;

namespace Zadanie7{
    class Program{
        private static List<double> numbers = new List<double>();
        
        static void Main(string[] args){
            Console.WriteLine("Wpisuj liczby w zakresie <0; 10>");
            while (true){
                try{
                    double number = Convert.ToDouble(Console.ReadLine());
                    if (number < 0 || number > 10){
                        Console.Error.WriteLine("Wprowadź numer w zakresie <0; 10>");
                        continue;
                    }

                    if (number.Equals(5d)){
                        break;
                    }
                    numbers.Add(number);
                }catch (FormatException ignored){
                    Console.Error.WriteLine("Wprowadzono nieprawidłowy numer");
                    return;
                }
            }

            double sum = 0;
            foreach (double number in numbers){
                sum += number;
            }
            double min = findMin(numbers);
            Console.WriteLine($"Suma podniesiona do kwadratu: {sum * sum}");
            Console.WriteLine($"Wartosc minimalna: {min}");
        }

        private static double findMin(List<double> nums){
            double[] doubles = nums.ToArray();
            if (doubles.Length == 0){
                return 0;
            }

            if (doubles.Length == 1){
                return doubles[0];
            }

            double min = doubles[0];
            for (int i = 1; i < doubles.Length; i++){
                min = Math.Min(min, doubles[i]);
            }

            return min;
        }
    }
}