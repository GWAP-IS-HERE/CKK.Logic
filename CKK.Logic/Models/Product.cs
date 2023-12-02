using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Product : Entity
    {
        private decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                price = value;
            }
        }

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
