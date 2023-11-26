using System;

namespace Zadanie6{
    class Program{
        static void Main(string[] args){
            for (int x = 0; x <= 10; x++)
            {
                double y = 3 * x;
                
                Console.WriteLine($"Dla x = {x}, y = {y}");
            }
        }
    }
}