using System;
using System.Security.Cryptography.X509Certificates;

namespace P06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string simbol = Console.ReadLine();

            if (simbol == "+" || simbol == "-" || simbol == "*")
            {
                int result = 0;
                string condition = "even";
                if (simbol == "+")
                {
                    result = n1 + n2;
                }
                else if (simbol == "-")
                {
                    result = (n1 - n2);
                }
                else if (simbol == "*")
                {
                    result = (n1 * n2);
                }
                if (result % 2 != 0) // това е за - числата включително (result % 2 == 1) това е само за положителни
                {
                    condition = "odd";
                }
                Console.WriteLine($"{n1} {simbol} {n2} = {result} - {condition}");
            }
            else
            {

                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero"); 
                }
                // return; ako се напище спира до тук и ако resulta на долните 2 е общ няма и той да излезне
                else if (simbol == "/")
                {
                    double result = (double)n1 / n2; // така казваме че може инт със инт правейки едната доубле с команда специално за този пример
                    Console.WriteLine($"{n1} {simbol} {n2} = {result:f2}");
                }
                else if (simbol == "%")
                {
                    int result = n1 % n2;
                    Console.WriteLine($"{n1} {simbol} {n2} = {result}");
                }
            }
        }
    }
}
