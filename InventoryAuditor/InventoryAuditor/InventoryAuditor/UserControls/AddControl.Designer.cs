namespace InventoryAuditor.UserControls
{
    partial class AddControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            ProductTextBox = new TextBox();
            ProductName = new Label();
            AmountLabel = new Label();
            AmountTextBox = new TextBox();
            ExitContainer = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(96, 209, 75);
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 179);
            button1.Name = "button1";
            button1.Size = new Size(316, 41);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProductTextBox
            // 
            ProductTextBox.BorderStyle = BorderStyle.None;
            ProductTextBox.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductTextBox.Location = new Point(0, 64);
            ProductTextBox.Margin = new Padding(0);
            ProductTextBox.Name = "ProductTextBox";
            ProductTextBox.PlaceholderText = "Enter Product";
            ProductTextBox.Size = new Size(316, 21);
            ProductTextBox.TabIndex = 6;
            ProductTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ProductName
            // 
            ProductName.FlatStyle = FlatStyle.Flat;
            ProductName.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductName.Location = new Point(0, 85);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(316, 25);
            ProductName.TabIndex = 7;
            ProductName.Text = "Product Name";
            ProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AmountLabel
            // 
            AmountLabel.FlatStyle = FlatStyle.Flat;
            AmountLabel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountLabel.Location = new Point(0, 151);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(316, 25);
            AmountLabel.TabIndex = 9;
            AmountLabel.Text = "Amount";
            AmountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AmountTextBox
            // 
            AmountTextBox.BorderStyle = BorderStyle.None;
            AmountTextBox.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountTextBox.Location = new Point(0, 130);
            AmountTextBox.Margin = new Padding(0);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.PlaceholderText = "Enter Amount";
            AmountTextBox.Size = new Size(316, 21);
            AmountTextBox.TabIndex = 8;
            AmountTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ExitContainer
            // 
            ExitContainer.BackColor = Color.WhiteSmoke;
            ExitContainer.FlatAppearance.BorderSize = 0;
            ExitContainer.FlatStyle = FlatStyle.Flat;
            ExitContainer.Location = new Point(236, 0);
            ExitContainer.Margin = new Padding(0);
            ExitContainer.Name = "ExitContainer";
            ExitContainer.Size = new Size(80, 27);
            ExitContainer.TabIndex = 10;
            ExitContainer.Text = "X";
            ExitContainer.UseVisualStyleBackColor = false;
            ExitContainer.Click += ExitContainer_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 27);
            panel1.TabIndex = 11;
            // 
            // AddControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ExitContainer);
            Controls.Add(AmountLabel);
            Controls.Add(AmountTextBox);
            Controls.Add(ProductName);
            Controls.Add(ProductTextBox);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "AddControl";
            Size = new Size(316, 220);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox ProductTextBox;
        private Label ProductName;
        private Label AmountLabel;
        private TextBox AmountTextBox;
        private Button ExitContainer;
        private Panel panel1;
    }
}
