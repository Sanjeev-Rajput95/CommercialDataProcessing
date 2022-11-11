﻿using StockManagement.Repository;

namespace StockManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============  WELCOME TO COMMERCIAL DATA PROCESSING PROGRAM ===================");


            StockManagementRepository repository = new StockManagementRepository();
            CommercialDataProcessing dataProcessing = new CommercialDataProcessing();

            Console.Write("Enter 't' to do Transaction in Stock Market : ");
            string input = Console.ReadLine();
            while (input == "t")
            {
                Console.WriteLine("\nSelect the Type of Transaction Which You want to do\n" +
                    "\n1.Buy the Shares from Company" +
                    "\n2.Sell the shares from Customer" +
                    "\n3.Total Value of Stocks belongs to Customer\n");
                Console.WriteLine("Enter the Number of Selected Type of Transaction");
                int TransactionCheck = Convert.ToInt32(Console.ReadLine());
                switch (TransactionCheck)
                {
                    case 1:
                        dataProcessing.DisplayCustomerInfo();
                        repository.StockPortfolio();
                        Console.Write("Enter the Customer Name Which You Want to Buy the Stocks : ");
                        string CustomerNameBuy = Console.ReadLine();
                        dataProcessing.DisplayCustomerInfo1(CustomerNameBuy);
                        Console.Write("Enter Company Name to Buy Stocks : ");
                        string CompanyNameBuy = Console.ReadLine();
                        repository.StockPortfolio1(CompanyNameBuy);
                        Console.Write("Enter Number of Stocks Which you want to Buy : ");
                        int NoOfSharesBuy = Convert.ToInt32(Console.ReadLine());
                        dataProcessing.BuyStocks(CustomerNameBuy, CompanyNameBuy, NoOfSharesBuy);
                        Console.WriteLine("\n******* Customer Updated Details *******");
                        dataProcessing.DisplayCustomerInfo1(CustomerNameBuy);
                        Console.WriteLine("\n******** Company Updated Details *******");
                        repository.StockPortfolio1(CompanyNameBuy);
                        break;

                    case 2:
                        dataProcessing.DisplayCustomerInfo();
                        repository.StockPortfolio();
                        Console.Write("Enter the Customer Name Which You Want to sell the Stocks : ");
                        string CustomerNameSell = Console.ReadLine();
                        dataProcessing.DisplayCustomerInfo1(CustomerNameSell);
                        Console.Write("Enter Company Name to Sell Stocks : ");
                        string CompanyNameSell = Console.ReadLine();
                        repository.StockPortfolio1(CompanyNameSell);
                        Console.Write("Enter Number of Stocks Which you want to Sell : ");
                        int NoOfSharesSell = Convert.ToInt32(Console.ReadLine());
                        dataProcessing.SellStocks(CustomerNameSell, CompanyNameSell, NoOfSharesSell);
                        Console.WriteLine("\n******* Customer Updated Details *******");
                        dataProcessing.DisplayCustomerInfo1(CustomerNameSell);
                        Console.WriteLine("\n******** Company Updated Details *******");
                        repository.StockPortfolio1(CompanyNameSell);
                        break;

                    case 3:
                        Console.Write("Enter Customer Name to get Total Value of Stocks of that Customer : ");
                        string CustomerName = Console.ReadLine();
                        dataProcessing.ValueOfAccounts(CustomerName);
                        break;
                }
                Console.Write("Enter 't' to do Transaction in Stock Market otherwise Enter any key : ");
                input = Console.ReadLine();
            }

        }
    }
}