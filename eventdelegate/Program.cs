using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventdelegate
{
    public class PriceChangedEventsArgs : EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;

        public PriceChangedEventsArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice; NewPrice = newPrice;
        }
    }

    public class Stock
    {
        string symbol;
        decimal price;

        public Stock(string symbol)
        {
            this.symbol = symbol;
        }

        public event EventHandler<PriceChangedEventsArgs> PriceChanged;

        protected virtual void OnPriceChanged(PriceChangedEventsArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (price == value ) return;
                decimal oldPrice = price;
                price = value;
                OnPriceChanged(new PriceChangedEventsArgs(oldPrice, price));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock("THPW");
            stock.Price = 21.10M;
            stock.PriceChanged += stock_PriceChanged;
            stock.Price = 31.59M;
            Console.ReadKey();

        }

        static void stock_PriceChanged(object sender, PriceChangedEventsArgs e)
        {
            if((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
                Console.WriteLine("Alert, 10% stock price increase!");
        }
    }
}
