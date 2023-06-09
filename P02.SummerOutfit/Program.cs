﻿using System;

namespace P02.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            string outfit = string.Empty; // и двете стават едно и също са
            string shoes = "";
            
            
            
            if (degrees >= 10 && degrees <= 18)
            {
                switch (partOfDay)
                {
                    case "Morning":
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        break;
                    case "Afternoon":
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }
            else if (degrees > 18 && degrees <= 24)
            {
                switch (partOfDay)
                {
                    case "Morning":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Afternoon":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }

            else if (degrees > 24)
            {
                switch (partOfDay)
                {
                    case "Morning":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Afternoon":
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }
            
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");       ///"It's {градуси} degrees, get your {облекло} and {обувки}."            
        }

    }
}
