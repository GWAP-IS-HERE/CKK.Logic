using CKK.Logic.Interfaces;
using CKK.Persistance.Interfaces;
using CKK.Logic.Models;
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using CKK.Logic.Exceptions;
using System.Linq;

namespace CKK.Persistance.Models
{
    public class FileStore : IStore, ISavable, ILoadable
    {
        private List<StoreItem> Items;
        public readonly string FilePath = "C:\\Users\\danie\\Documents\\Persistance\\StoreItems.dat";
        private int IdCounter;
        public FileStore()
        {
            CreatePath();
        }

        public StoreItem? AddStoreItem(Product productIn, int quantityIn)
        {
            if (productIn.Id == 0) //if the product doesn't have an id
            {
                int tempId = 0;
                foreach (var item in Items) //search the list for the highest id then add 1 to make the new highest id
                {
                    if (item.Product.Id >= tempId)
                        tempId = item.Product.Id + 1;
                }
                Items.Add(new StoreItem(productIn, quantityIn)); //then add and return
                return Items.Last();
            }

            if (quantityIn <= 0)
            {
                throw new InventoryItemStockTooLowException();
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
            //If the value isn't found, add a new one
            Items.Add(new StoreItem(productIn, quantityIn));
            return Items.Last();
        }

        public StoreItem? RemoveStoreItem(int idIn, int quantityIn)
        {
            if (quantityIn < 0)
                throw new ArgumentOutOfRangeException();
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
            throw new ProductDoesNotExistException();
        }

        public StoreItem? FindStoreItemById(int idIn)
        {
            if (idIn < 0)
                throw new InvalidIdException();
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

        public void DeleteStoreItem(int idIn)
        {
            for (int ctr = 0; ctr < Items.Count(); ctr++)
            {
                if (Items[ctr].Prod.Id == idIn)
                {
                    Items.RemoveAt(ctr);
                    return;
                }
            }
        }

        public void Load()
        {
            BinaryFormatter reader = new BinaryFormatter();
            try
            {
                FileStream input = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                Items = (List<StoreItem>)reader.Deserialize(input);
                input.Close();
            }
            catch
            {
                Items = new List<StoreItem>();
            }
        }

        public void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream output = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Write);

            formatter.Serialize(output, Items);
            output.Close();
        }

        private void CreatePath()
        {
            if (Directory.Exists("C:\\Users\\danie\\Documents\\Persistance\\"))
                return;
            Directory.CreateDirectory("C:\\Users\\danie\\Documents\\Persistance\\");
        }
    }
}
