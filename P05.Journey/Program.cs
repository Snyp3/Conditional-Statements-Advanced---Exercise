﻿using System;

namespace P05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string placeToRest = "";
            double price = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    placeToRest = "Camp";
                    price = budget * 0.3;
                }
                else if (season == "winter")
                {
                    placeToRest = "Hotel";
                    price = budget * 0.7;
                }

            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    placeToRest = "Camp";
                    price = budget * 0.4;
                }
                else if (season == "winter")
                {
                    placeToRest = "Hotel";
                    price = budget * 0.8;
                }

            }
            else if (budget > 1000)
            {
                destination = "Europe";
                placeToRest = "Hotel";
                price = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeToRest} - {price:F2}");
        }
    }
}
