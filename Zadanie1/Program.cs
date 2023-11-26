using System;

namespace Cwieczenia{
    class Program{
        static void Main(string[] args){
            double a = 3.5;
            double b = 6.0;

            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine($"Długość przeciwprostokątnej trójkąta prostokątnego o przyprostokątnych a = {a} i b = {b} wynosi c = {c}");
        }
    }
}