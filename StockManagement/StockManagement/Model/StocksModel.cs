using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Model
{
    public class StocksModel
    {
        public List<CommonProperties> Stocks { get; set; }
    }
    public class CommonProperties
    {
        public string CompanyName { get; set; }
        public int NoOfShares { get; set; }
        public double SharePrice { get; set; }
    }
}
