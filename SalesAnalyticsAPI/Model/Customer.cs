﻿namespace SalesAnalyticsAPI.Model
{
    public class Customer
    {
        public string CustomerID { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
