﻿namespace intranet.Models.Shipstation
{
    public class OrderList
    {
        public List<SsOrder> Orders { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
        public int Pages { get; set; }
    }
}
