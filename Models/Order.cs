﻿namespace Bookstore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public User User { get; set; }
    }
}
