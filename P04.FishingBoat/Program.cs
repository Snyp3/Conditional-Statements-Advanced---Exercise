    using System;

    namespace P04.FishingBoat
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                // •	Цената за наем на кораба през пролетта е  3000 лв.
                // •	Цената за наем на кораба през лятото и есента е  4200 лв.
                // •	Цената за наем на кораба през зимата е  2600 лв.


                // •	Ако групата е до 6 човека включително  –  отстъпка от 10 %.
                // •	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
                // •	Ако групата е от 12 нагоре  –  отстъпка от 25 %.


                //5 % отстъпка, ако са четен брой освен ако не е есен - тогава нямат допълнителна отстъпка,
                //    която се начислява след като се приспадне отстъпката по горните критерии.


                int budget = int.Parse(Console.ReadLine());
                string season = Console.ReadLine();
                int countFisherman = int.Parse(Console.ReadLine());

                double priceOfBoat = 0;              // : "Spring", "Summer", "Autumn", "Winter"

                if (season == "Spring")
                {
                    priceOfBoat = 3000;
                    if (countFisherman <= 6)
                    {
                        priceOfBoat *= 0.90;
                    }
                    else if (countFisherman >= 7 && countFisherman <= 11)
                    {
                        priceOfBoat *= 0.85;
                    }
                    else if (countFisherman >= 12)
                    {
                        priceOfBoat *= 0.75;
                    }
                }
                else if (season == "Summer")
                {
                    priceOfBoat = 4200;
                    if (countFisherman <= 6)
                    {
                        priceOfBoat *= 0.90;
                    }
                    else if (countFisherman >= 7 && countFisherman <= 11)
                    {
                        priceOfBoat *= 0.85;
                    }
                    else if (countFisherman >= 12)
                    {
                        priceOfBoat *= 0.75;
                    }
                }
                else if (season == "Autumn")
                {
                    priceOfBoat = 4200;
                    if (countFisherman <= 6)
                    {
                        priceOfBoat *= 0.90;
                    }
                    else if (countFisherman >= 7 && countFisherman <= 11)
                    {
                        priceOfBoat *= 0.85;
                    }
                    else if (countFisherman >= 12)
                    {
                        priceOfBoat *= 0.75;
                    }
                }
                else if (season == "Winter")
                {
                    priceOfBoat = 2600;
                    if (countFisherman <= 6)
                    {
                        priceOfBoat *= 0.90;
                    }
                    else if (countFisherman >= 7 && countFisherman <= 11)
                    {
                        priceOfBoat *= 0.85;
                    }
                    else if (countFisherman >= 12)
                    {
                        priceOfBoat *= 0.75;
                    }
                }
                if (countFisherman % 2 == 0)
                {
                    if (season == "Spring" || season == "Winter" || season == "Summer")
                    {
                        priceOfBoat *= 0.95; 
                    }
                       
                }
           
                if (budget >= priceOfBoat)
                {
                    double budgetLeft = budget - priceOfBoat;

                    Console.WriteLine($"Yes! You have {budgetLeft:f2} leva left.");
                }
                else 
                {
                    double budgetLess = priceOfBoat - budget;

                    Console.WriteLine($"Not enough money! You need {budgetLess:F2} leva.");
                }
            }
        }
    }
