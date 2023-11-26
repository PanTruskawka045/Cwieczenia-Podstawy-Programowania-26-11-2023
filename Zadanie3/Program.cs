using System;

namespace Zadanie3{
    class Program{
        //Rates for 26.11.2023
        private static double PLN_TO_USD = 3.99;
        private static double USD_TO_EUR = .91;
        private static double USD_TO_CHF = .88;
        private static double USD_TO_GBP = .79;


        static void Main(string[] args){
            Console.Write("Podaj, ile pieniedzy chcesz wymienic (w PLN): ");
            double pln;
            try{
                pln = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ignored){
                Console.WriteLine("Wprowadzono nieprawidłowy numer");
                return;
            }
            Console.Write("Podaj walute, na którą chcesz zmienic (USD, EUR, CHF, GBP): ");
            string currencyTo = Console.ReadLine();
            if (currencyTo == null){
                Console.WriteLine("Nie wprowadzono waluty");
                return;
            }

            double usd = pln / PLN_TO_USD;
            switch (currencyTo.ToUpper()){
                case "USD":
                    Console.WriteLine($"{pln} PLN to {usd} USD");
                    return;
                case "EUR":
                    Console.WriteLine($"{pln} PLN to {usd * USD_TO_EUR} EUR");
                    return;
                case "CHF":
                    Console.WriteLine($"{pln} PLN to {usd * USD_TO_CHF} CHF");
                    return;
                case "GBP":
                    Console.WriteLine($"{pln} PLN to {usd * USD_TO_GBP} GBP");
                    return;
            }
        }
    }
}