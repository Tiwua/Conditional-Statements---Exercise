using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();  // May , June , July , August , September or October
            int numberOfNights = int.Parse(Console.ReadLine());
            double priceForStudio = 0;
            double priceForAppartment = 0;

            switch (month)
            {
                case "May":
                    priceForStudio = 50 * numberOfNights;
                    priceForAppartment = 65 * numberOfNights;

                    if (numberOfNights > 7 && numberOfNights < 14)
                    {
                        priceForStudio -= priceForStudio * 0.05;
                    }
                    else if (numberOfNights > 14)
                    {
                        priceForStudio -= priceForStudio * 0.30;
                    }
                    if (numberOfNights > 14)
                    {
                        priceForAppartment -= priceForAppartment * 0.10;
                    }
                    break;

                case "October":
                    priceForStudio = 50 * numberOfNights;
                    priceForAppartment = 65 * numberOfNights;

                    if (numberOfNights > 7 && numberOfNights < 14)
                    {
                        priceForStudio -= priceForStudio * 0.05;
                    }
                    else if (numberOfNights > 14)
                    {
                        priceForStudio -= priceForStudio * 0.30;
                    }
                    if (numberOfNights > 14)
                    {
                        priceForAppartment -= priceForAppartment * 0.10;
                    }
                    break;
                case "June":
                    priceForStudio = 75.20 * numberOfNights;
                    priceForAppartment = 68.70 * numberOfNights;

                    if (numberOfNights > 14)
                    {
                        priceForStudio -= priceForStudio * 0.20;
                        priceForAppartment -= priceForAppartment * 0.10;
                    }
                    break;
                case "September":
                    priceForStudio = 75.20 * numberOfNights;
                    priceForAppartment = 68.70 * numberOfNights;

                    if (numberOfNights > 14)
                    {
                        priceForStudio -= priceForStudio * 0.20;
                    }
                    if (numberOfNights > 14)
                    {
                        priceForAppartment -= priceForAppartment * 0.10;
                    }
                    break;
                case "July":
                    priceForStudio = 76 * numberOfNights;
                    priceForAppartment = 77 * numberOfNights;

                    if (numberOfNights > 14)
                    {
                        priceForAppartment -= priceForAppartment * 0.10;
                    }
                    break;
                case "August":
                    priceForStudio = 76 * numberOfNights;
                    priceForAppartment = 77 * numberOfNights;

                    if (numberOfNights > 14)
                    {
                        priceForAppartment -= priceForAppartment * 0.10;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {priceForAppartment:f2} lv.");
            Console.WriteLine($"Studio: {priceForStudio:f2} lv.");
        }
    }
}