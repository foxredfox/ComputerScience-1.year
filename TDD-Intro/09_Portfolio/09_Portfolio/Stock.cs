using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Portfolio
{
    class Stock : IAsset
    {
        public String Symbol{get;set;}
        public double PricePerShare{get;set;}
        public int    NumShares{get;set;}

        public Stock(){}

        public Stock(String Symbol, double PricePerShare, int NumShares)
        {
            this.Symbol        = Symbol;
            this.PricePerShare = PricePerShare;
            this.NumShares     = NumShares;
        }

        public double GetValue(){return PricePerShare * NumShares;}

        public static double TotalValue(IAsset[] s)
        {
            return s.Sum(stock => stock.GetValue());
        }

        public override String ToString()
        {
            return "Stock[symbol="+Symbol+",pricePerShare="+PricePerShare.ToString().Replace(',','.')+",numShares="+NumShares.ToString()+"]";
        }

        public override bool Equals(object _s)
        {
            Stock s = (Stock)_s;
            
            if(s.Symbol != Symbol || s.PricePerShare != PricePerShare || s.NumShares != NumShares)
                return false;

            return true;
        }
    }
}