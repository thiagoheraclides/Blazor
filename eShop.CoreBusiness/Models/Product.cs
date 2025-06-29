﻿#nullable disable
namespace eShop.CoreBusiness.Models
{
    public class Product
    {
        public uint Id { get; set; }

        public string Brand { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string ImageLink { get; set; }

        public string Description { get; set; }

    }
}
