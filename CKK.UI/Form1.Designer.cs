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
            panel1 = new Panel();
            quantityOutput = new TextBox();
            priceOutput = new TextBox();
            nameOutput = new TextBox();
            quantityOutputLabel = new Label();
            priceOutputLabel = new Label();
            nameOutputLabel = new Label();
            deleteButton = new Button();
            editButton = new Button();
            previousButton = new Button();
            nextButton = new Button();
            positionIndicator = new Label();
            panel2 = new Panel();
            addButton = new Button();
            quantityInputLabel = new Label();
            priceInputLabel = new Label();
            nameInputLabel = new Label();
            quantityInput = new TextBox();
            priceInput = new TextBox();
            nameInput = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            // 
            // panel1
            // 
            panel1.Controls.Add(quantityOutput);
            panel1.Controls.Add(priceOutput);
            panel1.Controls.Add(nameOutput);
            panel1.Controls.Add(quantityOutputLabel);
            panel1.Controls.Add(priceOutputLabel);
            panel1.Controls.Add(nameOutputLabel);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(editButton);
            panel1.Location = new Point(401, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 219);
            panel1.TabIndex = 3;
            // 
            // quantityOutput
            // 
            quantityOutput.Enabled = false;
            quantityOutput.Location = new Point(81, 127);
            quantityOutput.Name = "quantityOutput";
            quantityOutput.Size = new Size(100, 23);
            quantityOutput.TabIndex = 12;
            // 
            // priceOutput
            // 
            priceOutput.Enabled = false;
            priceOutput.Location = new Point(81, 83);
            priceOutput.Name = "priceOutput";
            priceOutput.Size = new Size(100, 23);
            priceOutput.TabIndex = 11;
            // 
            // nameOutput
            // 
            nameOutput.Enabled = false;
            nameOutput.Location = new Point(81, 38);
            nameOutput.Name = "nameOutput";
            nameOutput.Size = new Size(100, 23);
            nameOutput.TabIndex = 10;
            // 
            // quantityOutputLabel
            // 
            quantityOutputLabel.AutoSize = true;
            quantityOutputLabel.Location = new Point(19, 130);
            quantityOutputLabel.Name = "quantityOutputLabel";
            quantityOutputLabel.Size = new Size(56, 15);
            quantityOutputLabel.TabIndex = 9;
            quantityOutputLabel.Text = "Quantity:";
            // 
            // priceOutputLabel
            // 
            priceOutputLabel.AutoSize = true;
            priceOutputLabel.Location = new Point(39, 86);
            priceOutputLabel.Name = "priceOutputLabel";
            priceOutputLabel.Size = new Size(36, 15);
            priceOutputLabel.TabIndex = 8;
            priceOutputLabel.Text = "Price:";
            // 
            // nameOutputLabel
            // 
            nameOutputLabel.AutoSize = true;
            nameOutputLabel.Location = new Point(33, 41);
            nameOutputLabel.Name = "nameOutputLabel";
            nameOutputLabel.Size = new Size(42, 15);
            nameOutputLabel.TabIndex = 7;
            nameOutputLabel.Text = "Name:";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(208, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(0, 196);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 0;
            editButton.Text = "edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // previousButton
            // 
            previousButton.Location = new Point(324, 221);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(71, 43);
            previousButton.TabIndex = 4;
            previousButton.Text = "previous";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(690, 221);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(71, 43);
            nextButton.TabIndex = 5;
            nextButton.Text = "next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // positionIndicator
            // 
            positionIndicator.AutoSize = true;
            positionIndicator.Location = new Point(538, 117);
            positionIndicator.Name = "positionIndicator";
            positionIndicator.Size = new Size(24, 15);
            positionIndicator.TabIndex = 6;
            positionIndicator.Text = "0/0";
            // 
            // panel2
            // 
            panel2.Controls.Add(addButton);
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
            // addButton
            // 
            addButton.Location = new Point(58, 172);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 8;
            addButton.Text = "add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(positionIndicator);
            Controls.Add(nextButton);
            Controls.Add(previousButton);
            Controls.Add(panel1);
            Controls.Add(searchButton);
            Controls.Add(searchInput);
            Controls.Add(logoutButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutButton;
        private TextBox searchInput;
        private Button searchButton;
        private Panel panel1;
        private Button previousButton;
        private Button nextButton;
        private Button deleteButton;
        private Button editButton;
        private Label positionIndicator;
        private TextBox quantityOutput;
        private TextBox priceOutput;
        private TextBox nameOutput;
        private Label quantityOutputLabel;
        private Label priceOutputLabel;
        private Label nameOutputLabel;
        private Panel panel2;
        private Button addButton;
        private Label quantityInputLabel;
        private Label priceInputLabel;
        private Label nameInputLabel;
        private TextBox quantityInput;
        private TextBox priceInput;
        private TextBox nameInput;
    }
}
