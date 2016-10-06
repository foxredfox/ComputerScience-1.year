using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _09_Portfolio
{
    class Portfolio
    {
        private List<IAsset> assets = new List<IAsset>();

        public Portfolio(){}
        public Portfolio(List<IAsset> a){assets = a;}

        public void AddAsset(IAsset a){assets.Add(a);}
        
        public double GetTotalValue()
        { 
            return assets.Sum(asset => asset.GetValue()); 
        }
    }
}
