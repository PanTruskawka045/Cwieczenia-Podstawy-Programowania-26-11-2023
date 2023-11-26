using System;

namespace Zadanie8{
    class Program{
        static void Main(string[] args){
            double num = 0;
            do{
                num++;
                Console.WriteLine($"{num} podniesione do kwadratu to {num * num}");
            } while (num < 20);
        }
    }
}