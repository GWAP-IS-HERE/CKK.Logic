using CKK.Logic.Models;
using CKK.Logic.Interfaces;

namespace CKK.UI
{
    public partial class Form1 : Form
    {
        private IStore store;
        private int index = 0;
        bool editMode = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            store = new Store();
            Product temp1 = new Product();
            Product temp2 = new Product();
            Product temp3 = new Product();
            temp1.Id = 1;
            temp1.Price = 2.49M;
            temp1.Name = "prod1";
            store.AddStoreItem(temp1, 1);
            temp2.Id = 2;
            temp2.Price = 6.99M;
            temp2.Name = "prod2";
            store.AddStoreItem(temp2, 2);
            temp3.Id = 3;
            temp3.Price = 16.54M;
            temp3.Name = "prod3";
            store.AddStoreItem(temp3, 3);
            if (store.GetStoreItems().Count() > 0)
                updateInputs(store.GetStoreItems().ElementAt(index));
            updateIndex();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (index > 0)
                index--;

            if (index >= store.GetStoreItems().Count())
                index = store.GetStoreItems().Count() - 1;
            if (store.GetStoreItems().Count() > 0)
                updateInputs(store.GetStoreItems().ElementAt(index));
            updateIndex();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (index < store.GetStoreItems().Count())
                index++;

            if (index >= store.GetStoreItems().Count())
                index = store.GetStoreItems().Count() - 1;

            if (store.GetStoreItems().Count() > 0)
                updateInputs(store.GetStoreItems().ElementAt(index));
            updateIndex();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            store.DeleteStoreItem(store.GetStoreItems().ElementAt(index).Prod.Id);
            if (index > 0)
                index--;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (editMode && validateEdit())
            {
                //switch edit mode off
                editMode = false;
                nameOutput.Enabled = false; //disable editing boxes
                priceOutput.Enabled = false;
                quantityOutput.Enabled = false;

                previousButton.Enabled = true; //enable other inputs
                nextButton.Enabled = true;
                searchButton.Enabled = true;
                searchInput.Enabled = true;
                addButton.Enabled = true;
                editButton.Text = "edit";
                store.GetStoreItems().ElementAt(index).Prod.Name = nameOutput.Text;
                store.GetStoreItems().ElementAt(index).Prod.Price = Convert.ToDecimal(priceOutput.Text);
                store.GetStoreItems().ElementAt(index).Quantity = Convert.ToInt32(quantityOutput.Text);
            }
            else
            {
                //switch edit mode on
                editMode = true;
                nameOutput.Enabled = true; //enable editing buttons
                priceOutput.Enabled = true;
                quantityOutput.Enabled = true;

                previousButton.Enabled = false; //disable other inputs
                nextButton.Enabled = false;
                searchButton.Enabled = false;
                searchInput.Enabled = false;
                addButton.Enabled = false;
                editButton.Text = "apply";
            }
        }

        private void updateInputs(StoreItem storeItem)
        {
            nameOutput.Text = storeItem.Product.Name;
            priceOutput.Text = Convert.ToString(storeItem.Product.Price);
            quantityOutput.Text = Convert.ToString(storeItem.Quantity);
        }

        private bool validateEdit()
        {
            try
            {
                Convert.ToDecimal(priceOutput.Text);
                Convert.ToInt32(quantityOutput.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void updateIndex()
        {
            positionIndicator.Text = Convert.ToString(index + 1) + "/" + Convert.ToString(store.GetStoreItems().Count());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Product temp = new Product();
                temp.Id = 0;
                temp.Name = nameInput.Text;
                temp.Price = Convert.ToDecimal(priceInput.Text);
                store.AddStoreItem(temp, Convert.ToInt32(quantityInput.Text));
                if (store.GetStoreItems().Count() > 0)
                    updateInputs(store.GetStoreItems().ElementAt(index));
                updateIndex();
            }
            catch { }
        }
    }
}
