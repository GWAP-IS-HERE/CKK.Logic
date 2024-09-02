using CKK.Logic.Models;
using CKK.Logic.Interfaces;
using CKK.Persistance.Interfaces;
using CKK.Persistance.Models;

namespace CKK.UI
{
    public partial class Form1 : Form
    {
        private FileStore store;
        private int index = 0;
        bool editMode = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            store = new FileStore();
            store.Load();

            updateInputs();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (index > 0)
                index--;

            if (index >= store.GetStoreItems().Count())
                index = store.GetStoreItems().Count() - 1;
            
            updateInputs();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (index < store.GetStoreItems().Count())
                index++;

            if (index >= store.GetStoreItems().Count())
                index = store.GetStoreItems().Count() - 1;

            updateInputs();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            store.DeleteStoreItem(store.GetStoreItems().ElementAt(index).Prod.Id);
            if (index > 0)
                index--;
            store.Save();
            updateInputs();
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
                store.Save();
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

        private void updateInputs()
        {
            if (store.GetStoreItems().Count() > 0)
            {
                StoreItem storeItem = store.GetStoreItems().ElementAt(index);
                nameOutput.Text = storeItem.Product.Name;
                priceOutput.Text = Convert.ToString(storeItem.Product.Price);
                quantityOutput.Text = Convert.ToString(storeItem.Quantity);
                positionIndicator.Text = Convert.ToString(index + 1) + "/" + Convert.ToString(store.GetStoreItems().Count());
            }
            else
            {
                nameOutput.Text = "";
                priceOutput.Text = "";
                quantityOutput.Text = "";
                positionIndicator.Text = "N/A";
            }
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

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Product temp = new Product();
                temp.Id = 0;
                temp.Name = nameInput.Text;
                temp.Price = Convert.ToDecimal(priceInput.Text);
                store.AddStoreItem(temp, Convert.ToInt32(quantityInput.Text));
                updateInputs();
                store.Save();
                nameInput.Text = "";
                priceInput.Text = "";
                quantityInput.Text = "";
            }
            catch { }
        }
    }
}
