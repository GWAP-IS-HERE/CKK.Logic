using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Store : Entity
    {
        private List<StoreItem> Items = new List<StoreItem>();

        /*
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
        }*/

        public StoreItem? AddStoreItem(Product productIn, int quantityIn)
        {
            if (quantityIn <= 0)
            {
                return null;
            }
            var myList =
                from item in Items
                where (productIn.Id == item.Prod.Id)
                select item;

            if (myList.Any())
            {
                myList.ElementAt(0).Quantity += quantityIn;
                return myList.ElementAt(0);
            }
            /*
            foreach (StoreItem value in Items)
            {
                if (productIn.Id == value.GetProduct().Id)
                {
                    value.SetQuantity(value.GetQuantity() + quantityIn);
                    return value;
                }
            }*/
            //If the value isn't found, add a new one
            Items.Add(new StoreItem(productIn, quantityIn));
            return Items.Last();
        }

        public StoreItem? RemoveStoreItem(int idIn, int quantityIn)
        {
            foreach (StoreItem value in Items)
            {
                if (idIn == value.Prod.Id)
                {
                    if (quantityIn >= value.Quantity)
                        value.Quantity = 0;
                    else
                        value.Quantity -= quantityIn;
                    return value;
                }
            }
            return null;
        }

        public StoreItem? FindStoreItemById(int idIn)
        {
            var myList =
                from item in Items
                where (idIn == item.Prod.Id)
                select item;

            if (myList.Any())
                return myList.ElementAt(0);
            
            return null;
        }

        public List<StoreItem> GetStoreItems()
        {
            return Items;
        }
    }
}
