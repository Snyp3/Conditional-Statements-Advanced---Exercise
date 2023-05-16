using System;

namespace P03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            double priceRoses = 5;
            double priceDahlias = 3.80;
            double priceTulips = 2.80;
            double priceNarcissus = 3;
            double priceGladiolus = 2.50;

            string flower = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;

              // •	Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
              // •	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
              // •	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
              // •	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
              // •	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %
                





            if (flower == "Roses")
            {
                if (flowerCount > 80)
                {
                    priceRoses *= 0.9;
                }
                totalPrice = priceRoses * flowerCount;
            }
            else if (flower == "Dahlias")
            {
                if (flowerCount > 90)
                {
                    priceDahlias *= 0.85;
                }
                totalPrice = priceDahlias * flowerCount;
            }
            else if (flower == "Tulips")
            {
                if (flowerCount > 80)
                {
                    priceTulips *= 0.85;
                }
                totalPrice = priceTulips * flowerCount;
            }
            else if (flower == "Narcissus")
            {
                if (flowerCount < 120)
                {
                    priceNarcissus *= 1.15;
                }
                totalPrice = priceNarcissus * flowerCount;
            }
            else if (flower == "Gladiolus")
            {
                if (flowerCount < 80)
                {
                    priceGladiolus *= 1.2;
                }
                totalPrice = priceGladiolus * flowerCount;
            }

           // •	Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
           // •	Ако бюджета им е НЕ достатъчен -"Not enough money, you need {нужната сума} leva more."

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flower} and {moneyLeft:F2} leva left.");
            }
            else 
            {
                double moneyNeedet = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeedet:F2} leva more.");
            }



        }

    }
}

