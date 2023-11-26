using System;

namespace Zadanie9{
    class Program{
        private static string[] pets = new[]{"cat", "dog", "parrot", "guinea pig"};

        static void Main(string[] args){
            foreach (string pet in pets){
                if (pet.Equals("dog")){
                    Console.WriteLine("End");
                    continue; //break;
                }

                Console.WriteLine(pet);
            }
        }
    }
}