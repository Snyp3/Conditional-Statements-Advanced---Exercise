using System;
using System.Transactions;

namespace P07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // •	За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
            // •	За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
            // •	За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
            // •	За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.

            string month = Console.ReadLine();
            int overnightStay = int.Parse(Console.ReadLine());


            double studio = 0;
            double apartment = 0;
            //May, June, July, August, September или October
            if (month == "May" || month == "October")
            {
                studio = 50;
                apartment = 65;
                if (overnightStay > 7 && overnightStay <=14)
                {
                    studio *= 0.95;
                   
                }
                else if (overnightStay > 14 )
                {
                    studio *= 0.70;
                    apartment *= 0.90;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20;
                apartment = 68.70;
                if ( overnightStay > 14)
                {
                    studio *= 0.80;
                    apartment *= 0.90;
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = 76;
                apartment = 77;
                if ( overnightStay > 14)
                {
                    apartment *= 0.90;
                }
            }
            double priceApartment = overnightStay * apartment;
            double priceStudio = overnightStay * studio;
            Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
            Console.WriteLine($"Studio: {priceStudio:F2} lv." );
        }
    }
}
