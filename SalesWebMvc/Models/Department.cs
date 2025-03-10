﻿using SalesWebMvc.Controllers;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() { }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateOnly DateInitial, DateOnly DateFinal)
        {
            return Sellers.Sum(Seller => Seller.TotalSales(DateInitial, DateFinal));
        }
    }
}
