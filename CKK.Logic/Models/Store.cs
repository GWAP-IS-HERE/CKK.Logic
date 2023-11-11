namespace CKK.Logic.Models
{
    public class Store
    {
        private int Id;
        private string Name = "";
        private List<StoreItem> Items = new List<StoreItem>();

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

        public StoreItem AddStoreItem(Product productIn, int quantityIn)
        {
            foreach (StoreItem value in Items)
            {
                if (productIn.GetId() == value.GetProduct().GetId())
                {
                    value.SetQuantity(value.GetQuantity() + quantityIn);
                    return value;
                }
            }
            //If the value isn't found, add a new one
            Items.Add(new StoreItem(productIn, quantityIn));
            return Items.Last();
        }

        public StoreItem? RemoveStoreItem(int idIn, int quantityIn)
        {
            foreach (StoreItem value in Items)
            {
                if (idIn == value.GetProduct().GetId())
                {
                    if (quantityIn >= value.GetQuantity())
                        value.SetQuantity(0);
                    else
                        value.SetQuantity(value.GetQuantity() - quantityIn);
                    return value;
                }
            }
            return null;
        }

        public StoreItem? FindStoreItemById(int idIn)
        {
            foreach(StoreItem value in Items)
            {
                if (idIn == value.GetProduct().GetId())
                {
                    return value;
                }
            }
            return null;
        }

        public List<StoreItem> GetStoreItems()
        {
            return Items;
        }
    }
}
