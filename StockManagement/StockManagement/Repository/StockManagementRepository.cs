using Newtonsoft.Json;
using StockManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Repository
{
    public class StockManagementRepository
    {
        public string JsonFilePath = @"C:\Bridgelabz\Commercial data processing\CommercialDataProcessing\StockManagement\StockManagement\JSON\StocksData.json";

        public void StockPortfolio()
        {
            string JsonFileData = File.ReadAllText(JsonFilePath);
            StocksModel StocksData = JsonConvert.DeserializeObject<StocksModel>(JsonFileData);

            Console.WriteLine("******************** Company Details ********************");

            foreach (var Stocks in StocksData.Stocks)
            {
                Console.Write("Company Name : " + Stocks.CompanyName +
                "\nNumber of Stocks : " + Stocks.NoOfShares +
                "\nPrice Of One Share : Rs." + Stocks.SharePrice + "\n");

                Console.WriteLine("---------------------------------------------");
            }

        }
        public void StockPortfolio1(string CompnayName)
        {
            bool CompanyExist = false;
            string JsonFileData = File.ReadAllText(JsonFilePath);
            StocksModel StocksData = JsonConvert.DeserializeObject<StocksModel>(JsonFileData);
            foreach (var Stocks in StocksData.Stocks)
            {
                if (Stocks.CompanyName == CompnayName)
                {
                    CompanyExist = true;
                    Console.Write("Company Name : " + Stocks.CompanyName +
                    "\nNumber of Stocks : " + Stocks.NoOfShares +
                    "\nPrice Of One Share : Rs." + Stocks.SharePrice + "\n\n");
                    break;
                }
            }
            if (!CompanyExist) ;
            {
                Console.WriteLine($"{CompnayName} Doesn't Exist in Company List");
            }

        }
    }
}
