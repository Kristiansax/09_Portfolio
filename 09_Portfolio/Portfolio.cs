using System.Collections.Generic;
namespace _09_Portfolio
    
{
    public class Portfolio
    {
        List<IAsset> assetlist = new List<IAsset>();
        public Portfolio()
        {
            assetlist = new List<IAsset>();
        }
        public Portfolio(List<IAsset> List)
            {
                assetlist = List;
            }
        public double GetTotalValue()
        {
            double Total = 0;
            foreach (IAsset item in assetlist)
                Total = Total + item.GetValue();
            return Total;
        }
        public void AddAsset(IAsset asset)
        {
            assetlist.Add(asset);
        }
    }
}