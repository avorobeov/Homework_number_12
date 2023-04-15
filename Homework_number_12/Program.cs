using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_12
{
    class Program
    {
        static void Main(string[] args)
        {
            const string StopCommand = "Exit";
            string inputUser;
            bool isExit = false;
            double rub = 100;
            double usd = 100;
            double uah = 100;
            double exchangeRateUsdInRub = 82.28;
            double exchangeRateUsdInUah = 36.78;
            double exchangeRateRubInUsd = 0.012;
            double exchangeRateRubInUah = 0.45;
            double exchangeRateUahInRub = 2.24;
            double exchangeRateUahInUsd = 0.027;
            double exchangeAmount;
            
            while (isExit == false)
            {
                Console.WriteLine($"На вашем счету (RUB) : {rub}\n" +
                                  $"На вашем счету (USD) : {usd}\n" +
                                  $"На вашем счету (UAH) : {uah}\n\n");
                Console.WriteLine("Добрый день приветствую вас в нашем обменнике вы можете здесь поменять:\n" +
                                  "для того что бы поменять Usd на Rub нажмите (1)\n" +
                                  "для того что бы поменять Usd на Uah нажмите (2)\n" +
                                  "для того что бы поменять Rub на Usd нажмите (3)\n" +
                                  "для того что бы поменять Rub на Uah нажмите (4)\n" +
                                  "для того что бы поменять Uah на Rub нажмите (5)\n" +
                                  "для того что бы поменять Uah на Usd нажмите (6)\n");

                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case "1":
                        Console.Write("Укажите суму которую, хотите поменять: ");
                        exchangeAmount = Convert.ToDouble(Console.ReadLine());

                        usd -= exchangeAmount;
                        rub += exchangeAmount * exchangeRateUsdInRub;
                        break;

                    case "2":
                        Console.Write("Укажите суму которую, хотите поменять: ");
                        exchangeAmount = Convert.ToDouble(Console.ReadLine());

                        usd -= exchangeAmount;
                        uah += exchangeAmount * exchangeRateUsdInUah;
                        break;

                    case "3":
                        Console.Write("Укажите суму которую, хотите поменять: ");
                        exchangeAmount = Convert.ToDouble(Console.ReadLine());

                        rub -= exchangeAmount;
                        usd += exchangeAmount * exchangeRateRubInUsd;
                        break;

                    case "4":
                        Console.Write("Укажите суму которую, хотите поменять: ");
                        exchangeAmount = Convert.ToDouble(Console.ReadLine());

                        rub -= exchangeAmount;
                        uah += exchangeAmount * exchangeRateRubInUah;
                        break;

                    case "5":
                        Console.Write("Укажите суму которую, хотите поменять: ");
                        exchangeAmount = Convert.ToDouble(Console.ReadLine());

                        uah -= exchangeAmount;
                        rub += exchangeAmount * exchangeRateUahInRub;
                        break;

                    case "6":
                        Console.Write("Укажите суму которую, хотите поменять: ");
                        exchangeAmount = Convert.ToDouble(Console.ReadLine());

                        uah -= exchangeAmount;
                        usd += exchangeAmount * exchangeRateUahInUsd;
                        break;

                    case StopCommand:
                        isExit = true;
                        break;
                }
            }
        }
    }
}
