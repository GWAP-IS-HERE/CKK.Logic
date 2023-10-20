namespace CKK.Logic.Models
{
    internal class Product
    {
        private int id;
        private string name;
        private decimal price;

        Product() { }

        public int GetId()
        {
            return id;
        }

        public void SetId(int idIn)
        {
            id = idIn;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string nameIn)
        {
            name = nameIn;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public void SetPrice(decimal priceIn)
        {
            price = priceIn;
        }
    }
}
