﻿namespace SalesDAL.Data.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? CreditCardNumber { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public ICollection<Sale>? Sales { get; set; }
    }
}