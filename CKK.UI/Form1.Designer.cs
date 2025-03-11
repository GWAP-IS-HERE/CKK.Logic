namespace CKK.UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            logoutButton = new Button();
            searchInput = new TextBox();
            searchButton = new Button();
            panel2 = new Panel();
            productIndicator = new Label();
            productLabel = new Label();
            deleteButton = new Button();
            applyButton = new Button();
            quantityInputLabel = new Label();
            priceInputLabel = new Label();
            nameInputLabel = new Label();
            quantityInput = new TextBox();
            priceInput = new TextBox();
            nameInput = new TextBox();
            deletePanel = new Panel();
            deleteConfirmButton = new Button();
            deleteCancelButton = new Button();
            confirmDeleteLabel = new Label();
            addButton = new Button();
            displayBox = new ListBox();
            inputInvalidPanel = new Panel();
            inputInvalidLabel = new Label();
            showAllButton = new Button();
            panel2.SuspendLayout();
            deletePanel.SuspendLayout();
            inputInvalidPanel.SuspendLayout();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(12, 12);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(77, 72);
            logoutButton.TabIndex = 0;
            logoutButton.Text = "LOG OUT";
            logoutButton.UseVisualStyleBackColor = true;
            // 
            // searchInput
            // 
            searchInput.Location = new Point(242, 12);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(442, 23);
            searchInput.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(690, 12);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 2;
            searchButton.Text = "search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(productIndicator);
            panel2.Controls.Add(productLabel);
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(applyButton);
            panel2.Controls.Add(quantityInputLabel);
            panel2.Controls.Add(priceInputLabel);
            panel2.Controls.Add(nameInputLabel);
            panel2.Controls.Add(quantityInput);
            panel2.Controls.Add(priceInput);
            panel2.Controls.Add(nameInput);
            panel2.Location = new Point(22, 135);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 219);
            panel2.TabIndex = 7;
            // 
            // productIndicator
            // 
            productIndicator.AutoSize = true;
            productIndicator.Location = new Point(95, 9);
            productIndicator.Name = "productIndicator";
            productIndicator.Size = new Size(25, 15);
            productIndicator.TabIndex = 14;
            productIndicator.Text = "n/a";
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new Point(23, 9);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(66, 15);
            productLabel.TabIndex = 8;
            productLabel.Text = "Product ID:";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(104, 171);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // applyButton
            // 
            applyButton.Location = new Point(23, 171);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(75, 23);
            applyButton.TabIndex = 8;
            applyButton.Text = "apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // quantityInputLabel
            // 
            quantityInputLabel.AutoSize = true;
            quantityInputLabel.Location = new Point(9, 130);
            quantityInputLabel.Name = "quantityInputLabel";
            quantityInputLabel.Size = new Size(56, 15);
            quantityInputLabel.TabIndex = 10;
            quantityInputLabel.Text = "Quantity:";
            // 
            // priceInputLabel
            // 
            priceInputLabel.AutoSize = true;
            priceInputLabel.Location = new Point(29, 86);
            priceInputLabel.Name = "priceInputLabel";
            priceInputLabel.Size = new Size(36, 15);
            priceInputLabel.TabIndex = 9;
            priceInputLabel.Text = "Price:";
            // 
            // nameInputLabel
            // 
            nameInputLabel.AutoSize = true;
            nameInputLabel.Location = new Point(23, 41);
            nameInputLabel.Name = "nameInputLabel";
            nameInputLabel.Size = new Size(42, 15);
            nameInputLabel.TabIndex = 8;
            nameInputLabel.Text = "Name:";
            // 
            // quantityInput
            // 
            quantityInput.Location = new Point(71, 127);
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(100, 23);
            quantityInput.TabIndex = 13;
            // 
            // priceInput
            // 
            priceInput.Location = new Point(71, 83);
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(100, 23);
            priceInput.TabIndex = 12;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(71, 38);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(100, 23);
            nameInput.TabIndex = 11;
            // 
            // deletePanel
            // 
            deletePanel.BackColor = Color.MistyRose;
            deletePanel.Controls.Add(deleteConfirmButton);
            deletePanel.Controls.Add(deleteCancelButton);
            deletePanel.Controls.Add(confirmDeleteLabel);
            deletePanel.Location = new Point(22, 376);
            deletePanel.Name = "deletePanel";
            deletePanel.Size = new Size(200, 62);
            deletePanel.TabIndex = 8;
            deletePanel.Visible = false;
            // 
            // deleteConfirmButton
            // 
            deleteConfirmButton.BackColor = Color.LightCoral;
            deleteConfirmButton.Location = new Point(104, 28);
            deleteConfirmButton.Name = "deleteConfirmButton";
            deleteConfirmButton.Size = new Size(75, 23);
            deleteConfirmButton.TabIndex = 9;
            deleteConfirmButton.Text = "delete";
            deleteConfirmButton.UseVisualStyleBackColor = false;
            deleteConfirmButton.Click += deleteConfirmButton_Click;
            // 
            // deleteCancelButton
            // 
            deleteCancelButton.Location = new Point(23, 28);
            deleteCancelButton.Name = "deleteCancelButton";
            deleteCancelButton.Size = new Size(75, 23);
            deleteCancelButton.TabIndex = 1;
            deleteCancelButton.Text = "cancel";
            deleteCancelButton.UseVisualStyleBackColor = true;
            deleteCancelButton.Click += deleteCancelButton_Click;
            // 
            // confirmDeleteLabel
            // 
            confirmDeleteLabel.AutoSize = true;
            confirmDeleteLabel.Location = new Point(9, 10);
            confirmDeleteLabel.Name = "confirmDeleteLabel";
            confirmDeleteLabel.Size = new Size(179, 15);
            confirmDeleteLabel.TabIndex = 0;
            confirmDeleteLabel.Text = "Are you sure you want to delete?";
            // 
            // addButton
            // 
            addButton.Location = new Point(81, 106);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 10;
            addButton.Text = "add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // displayBox
            // 
            displayBox.FormattingEnabled = true;
            displayBox.ItemHeight = 15;
            displayBox.Location = new Point(242, 106);
            displayBox.Name = "displayBox";
            displayBox.Size = new Size(546, 334);
            displayBox.TabIndex = 11;
            displayBox.SelectedIndexChanged += displayBox_SelectedIndexChanged;
            // 
            // inputInvalidPanel
            // 
            inputInvalidPanel.BackColor = Color.MistyRose;
            inputInvalidPanel.Controls.Add(inputInvalidLabel);
            inputInvalidPanel.Location = new Point(95, 12);
            inputInvalidPanel.Name = "inputInvalidPanel";
            inputInvalidPanel.Size = new Size(141, 72);
            inputInvalidPanel.TabIndex = 12;
            inputInvalidPanel.Visible = false;
            // 
            // inputInvalidLabel
            // 
            inputInvalidLabel.AutoSize = true;
            inputInvalidLabel.Location = new Point(28, 29);
            inputInvalidLabel.Name = "inputInvalidLabel";
            inputInvalidLabel.Size = new Size(87, 15);
            inputInvalidLabel.TabIndex = 0;
            inputInvalidLabel.Text = "Input not valid!";
            // 
            // showAllButton
            // 
            showAllButton.Location = new Point(474, 61);
            showAllButton.Name = "showAllButton";
            showAllButton.Size = new Size(75, 23);
            showAllButton.TabIndex = 13;
            showAllButton.Text = "Show All";
            showAllButton.UseVisualStyleBackColor = true;
            showAllButton.Click += showAllButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showAllButton);
            Controls.Add(inputInvalidPanel);
            Controls.Add(displayBox);
            Controls.Add(addButton);
            Controls.Add(deletePanel);
            Controls.Add(panel2);
            Controls.Add(searchButton);
            Controls.Add(searchInput);
            Controls.Add(logoutButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            deletePanel.ResumeLayout(false);
            deletePanel.PerformLayout();
            inputInvalidPanel.ResumeLayout(false);
            inputInvalidPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutButton;
        private TextBox searchInput;
        private Button searchButton;
        private Panel deletePanel;
        private Button previousButton;
        private Button nextButton;
        private Button editButton;
        private Label positionIndicator;
        private TextBox quantityOutput;
        private TextBox priceOutput;
        private TextBox nameOutput;
        private Label quantityOutputLabel;
        private Label priceOutputLabel;
        private Label nameOutputLabel;
        private Panel panel2;
        private Button applyButton;
        private Label quantityInputLabel;
        private Label priceInputLabel;
        private Label nameInputLabel;
        private TextBox quantityInput;
        private TextBox priceInput;
        private TextBox nameInput;
        private Button deleteButton;
        private Label productLabel;
        private Label productIndicator;
        private Label confirmDeleteLabel;
        private Button deleteConfirmButton;
        private Button deleteCancelButton;
        private Button addButton;
        private ListBox displayBox;
        private Panel inputInvalidPanel;
        private Label inputInvalidLabel;
        private Button showAllButton;
    }
}
