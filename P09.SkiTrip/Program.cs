using System;

namespace P09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayForStay = int.Parse(Console.ReadLine());
            string roomForStay = Console.ReadLine();
            string rating = Console.ReadLine();

            dayForStay -= 1;

            double priceRoom = 0;

            //"room for one person", "apartment" или "president apartment"
            if (roomForStay == "room for one person")
            {
                priceRoom = 18;
            }
            else if (roomForStay == "apartment")
            {
                priceRoom = 25;
                if (dayForStay < 10)
                {
                    priceRoom *= 0.70;
                }
                else if (dayForStay >= 10 && dayForStay < 15)
                {
                    priceRoom *= 0.65;
                }
                else if (dayForStay >= 15)
                {
                    priceRoom *= 0.50;
                }
            }
            else if (roomForStay == "president apartment")
            {
                priceRoom = 35;
                if (dayForStay < 10)
                {
                    priceRoom *= 0.90;
                }
                else if (dayForStay >= 10 && dayForStay < 15)
                {
                    priceRoom *= 0.85;
                }
                else if (dayForStay >= 15)
                {
                    priceRoom *= 0.80;
                }

            }
            double totalPrice = priceRoom * dayForStay;

            if (rating == "positive")
            {
                totalPrice = totalPrice + totalPrice *  0.25;
            }
            else if (rating == "negative")
            {
                totalPrice = totalPrice - totalPrice * 0.10;
            }

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
