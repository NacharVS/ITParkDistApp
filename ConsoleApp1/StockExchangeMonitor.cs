using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StockExchangeMonitor
    {
        public delegate void PriceChange(int price);

        public PriceChange _priceChangeHandler;

        public PriceChange PriceChangeHandler { get => _priceChangeHandler; set => _priceChangeHandler = value; }

        public void Start()
        {
            while (true)
            {
                int bankOfAmericaPrice = (new Random()).Next(100);

                PriceChangeHandler(bankOfAmericaPrice);

                Thread.Sleep(2000);
            }
        }
    }
}
