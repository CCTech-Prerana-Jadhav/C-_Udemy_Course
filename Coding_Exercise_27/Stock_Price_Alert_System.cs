using System;

namespace Coding.Exercise
{
    public delegate void StockPriceChangedHandler(string message);

    public class Stock
    {
        public event StockPriceChangedHandler OnStockPriceChanged;

        private decimal _price;
        private decimal _threshold;

        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                if (_price < _threshold)
                {
                    RaiseStockPriceChangedEvent($"Stock Alert: Stock price is below threshold! Current Price: {_price}");
                }
                else
                {
                    Console.WriteLine($"No alert. Current Price: {_price}");
                }
            }
        }

        public decimal Threshold
        {
            get { return _threshold; }
            set { _threshold = value; }
        }

        protected virtual void RaiseStockPriceChangedEvent(string message)
        {
            OnStockPriceChanged?.Invoke(message);
        }
    }

    public class StockAlert
    {
        public void OnStockPriceChanged(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Exercise
    {
        public static void Main(string[] args)
        {
            Stock stock = new Stock();
            StockAlert alert = new StockAlert();
            
            stock.OnStockPriceChanged += alert.OnStockPriceChanged;

            stock.Threshold = 100;

            stock.Price = 120; 
            stock.Price = 90;  
        }
    }
}
