using System;
using System.Reflection;

namespace P01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 0;

            if (film == "Premiere")
            {
                price = 12.00;
            }
            else if (film == "Normal")
            {
                price = 7.50;
            }
            else if (film == "Discount")
            {
                price = 5.00;
            }
            Console.WriteLine($"{ row * columns * price:f2} leva");

        }
    }
}
