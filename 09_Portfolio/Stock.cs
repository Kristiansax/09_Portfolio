using System;
namespace _09_Portfolio
{
    internal class Stock
    {
        public Stock()
        {

        }
        public Stock(string Type, double PPS, int AmountOfShares)
        {
            Symbol = Type;
            PricePerShare = PPS;
            NumShares = AmountOfShares;
        }
        private string symbol;
        private double pricepershare;
        private int numshares;
        
        public string Symbol
        {
            set
            {
                symbol = value;
            }
            get
            {
                return symbol;
            }
        }
        public double PricePerShare
        {
            set
            {
                pricepershare = value;
            }
            get
            {
                return pricepershare;
            }
        }
        public int NumShares
        {
            set
            {
                numshares = value;
            }
            get
            {
                return numshares;
            }
        }
        public double GetValue()
        {
            return NumShares * PricePerShare; 
        }
        public static double TotalValue(Stock[] stocks)
        {
            return stocks[0].GetValue() + stocks[1].GetValue();
        }
        public override string ToString()
        {
            return "Stock[symbol="+ Symbol +",pricePerShare="+ PricePerShare +",numShares="+ NumShares +"]";
        }
        public bool Equals(Stock SameCheck)
        {
            if (Symbol.Equals(SameCheck.Symbol) && PricePerShare.Equals(SameCheck.PricePerShare) && NumShares.Equals(SameCheck.NumShares))
                return true;
            else
                return false;
        }

    }
}