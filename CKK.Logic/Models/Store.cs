namespace CKK.Logic.Models
{
    public class Store
    {
        private int Id;
        private string Name = "";
        private Product? Product1 = null;
        private Product? Product2 = null;
        private Product? Product3 = null;

        public int GetId()
        {
            return Id;
        }

        public void SetId(int IdIn)
        {
            Id = IdIn;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string NameIn)
        {
            Name = NameIn;
        }

        public void AddStoreItem(Product productIn)
        {
            if (Product1 == null)
            {
                Product1 = productIn;
            }
            else if (Product2 == null)
            {
                Product2 = productIn;
            }
            else if (Product3 == null)
            {
                Product3 = productIn;
            }
        }

        public void RemoveStoreItem(int productNum)
        {
            switch (productNum)
            {
                case 1:
                    Product1 = null;
                    break;
                case 2:
                    Product2 = null;
                    break;
                case 3:
                    Product3 = null;
                    break;
            }
        }

        public Product? GetStoreItem(int productNum)
        {
            switch (productNum)
            {
                case 1:
                    if (Product1 != null)
                        return Product1;
                    else
                        return null;
                case 2:
                    if (Product2 != null)
                        return Product2;
                    else
                        return null;
                case 3:
                    if (Product3 != null)
                        return Product3;
                    else
                        return null;
                default:
                    return null;
            }
        }

        public Product? FindStoreItemById(int idIn)
        {
            if (Product1 != null && Product1.GetId() == idIn)
                return Product1;

            if (Product2 != null && Product2.GetId() == idIn)
                return Product2;

            if (Product3 != null && Product3.GetId() == idIn)
                return Product3;

            return null;
        }
    }
}
