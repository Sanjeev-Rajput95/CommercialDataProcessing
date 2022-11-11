﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Model
{
    public class CustomerInfo
    {
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public double Balance { get; set; }
    }
    public class ShareDetail
    {
        public string CompanyName { get; set; }
        public int NoOfShares { get; set; }
        public double SharePrice { get; set; }
    }
    public class StockAccount
    {
        public CustomerInfo CustomerInfo { get; set; }
        public List<ShareDetail> ShareDetail { get; set; }
    }

}
