using CKK.Logic.Models;
using CKK.DB.UOW;
using CKK.DB.Interfaces;

namespace CKK.UI
{
    public partial class Form1 : Form
    {
        private CKK.DB.Interfaces.IUnitOfWork store;
        private int currentProduct;
        private List<Product> display;
        public Form1(IUnitOfWork uow)
        {
            InitializeComponent();
            store = uow;
            currentProduct = -1;
        }

        private void displayAll() //incomplete
        {
            displayBox.Items.Clear();
            foreach (var item in store.Products.GetAll())
            {
                displayBox.Items.Add(item.Name);
            }
        }

        private void showInputInvalid()
        {
            inputInvalidPanel.Show();
        }
        private void hideInputInvalid()
        {
            inputInvalidPanel.Hide();
        }


        private bool validateEdit()
        {
            try
            {
                Convert.ToDecimal(priceInput.Text);
                Convert.ToInt32(quantityInput.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (validateEdit() && currentProduct != -1 && (nameInput.Text == store.Products.GetById(currentProduct).Name || store.Products.GetByName(nameInput.Text).Count == 0))
            {
                Product temp = store.Products.GetById(currentProduct);
                temp.Name = nameInput.Text;
                temp.Price = Convert.ToDecimal(priceInput.Text);
                temp.Quantity = Convert.ToInt32(quantityInput.Text);
                store.Products.Update(temp);
                hideInputInvalid();
                displayAll();
                resetSelection();
            }
            else
            {
                showInputInvalid();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (currentProduct != -1)
            {
                deletePanel.Show();
                addButton.Enabled = false;
                deleteButton.Enabled = false;
                applyButton.Enabled = false;
                searchButton.Enabled = false;
                displayBox.Enabled = false;
            }
            hideInputInvalid();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            displayBox.Items.Clear();
            foreach (var item in store.Products.GetByName(searchInput.Text))
            {
                displayBox.Items.Add(item.Name);
            }
        }

        private void deleteCancelButton_Click(object sender, EventArgs e)
        {
            deletePanel.Hide();
            addButton.Enabled = true;
            deleteButton.Enabled = true;
            applyButton.Enabled = true;
            searchButton.Enabled = true;
            displayBox.Enabled = true;
        }

        private void deleteConfirmButton_Click(object sender, EventArgs e)
        {
            deletePanel.Hide();
            addButton.Enabled = true;
            deleteButton.Enabled = true;
            applyButton.Enabled = true;
            searchButton.Enabled = true;
            displayBox.Enabled = true;
            store.Products.Delete(currentProduct);
            displayAll();
            resetSelection();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            Product prod = new Product();
            prod.Name = nameInput.Text;
            if (validateEdit() && store.Products.GetByName(prod.Name).Count == 0)
            {
                prod.Quantity = Convert.ToInt32(quantityInput.Text);
                prod.Price = Convert.ToDecimal(priceInput.Text);
                store.Products.Add(prod);
                hideInputInvalid();
                resetSelection();
            }
            else
            {
                showInputInvalid();
            }
            displayAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in store.Products.GetAll())
            {
                displayBox.Items.Add(item.Name);
            }
        }

        private void resetSelection()
        {
            productIndicator.Text = "n/a";
            currentProduct = -1;
            nameInput.Text = "";
            priceInput.Text = "";
            quantityInput.Text = "";
        }

        private void setSelection(int input)
        {
            currentProduct = input;
            productIndicator.Text = Convert.ToString(currentProduct);
        }

        private void fillInputBoxes()
        {
            if (currentProduct != -1)
            {
                Product temp = store.Products.GetById(currentProduct);
                nameInput.Text = temp.Name;
                priceInput.Text = Convert.ToString(temp.Price);
                quantityInput.Text = Convert.ToString(temp.Quantity);
            }
        }

        private void displayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var temp = displayBox.SelectedItem;
            if (temp != null)
                setSelection(store.Products.GetByName(temp.ToString())[0].Id);
            else
                resetSelection();
            fillInputBoxes();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            displayAll();
            searchInput.Text = "";
        }
    }
}