﻿using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Product : Entity
    {
        public decimal Price { get; set; }

        /* No longer necessary
        public int Id
        {
            return Id;
        }

        public void SetId(int IdIn)
        {
            Id = IdIn;
        }

        public string Name
        {
            return Name;
        }

        public void SetName(string NameIn)
        {
            Name = NameIn;
        }

        public decimal Price
        {
            return price;
        }

        public void SetPrice(decimal priceIn)
        {
            price = priceIn;
        }*/
    }
}
