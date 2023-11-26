using System;

namespace Zadanie4{
    class Program{
        static void Main(string[] args){
            Console.Write("What's your age (in years): ");
            double age;
            try{
                age = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ignored){
                Console.WriteLine("Invalid number provided");
                return;
            }

            if (age >= 18){
                Console.WriteLine("Access Granted");
                return;
            }
            
            if (age < 15){
                Console.WriteLine("Access Dennied");
                return;
            }
            
            Console.Write("Do you have parental consent? (yes/no): ");
            string input = Console.ReadLine();
            if (input == null){
                Console.WriteLine("Access Dennied");
                return;
            }

            input = input.ToLower();
            if (input == "yes"){
                Console.WriteLine("Access Granted");
                return;
            }
            //Let's assume every other answer is no
            Console.WriteLine("Access Dennied");
        }
    }
}