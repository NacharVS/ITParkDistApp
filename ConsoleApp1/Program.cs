using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StockExchangeMonitor stockExchangeMonitor = new StockExchangeMonitor();

            stockExchangeMonitor.PriceChangeHandler = ShowPrice;

            stockExchangeMonitor.Start();
        }

        public static void ShowPrice(int price)
        {
            Console.WriteLine($"New price: {price}");
        }
    }
}
