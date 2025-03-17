namespace InventoryAuditor.UserControls
{
    partial class EditControl
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
            ExitContainer = new Button();
            label1 = new Label();
            ProductTextBox = new TextBox();
            ProductName = new Label();
            AmountTextBox = new TextBox();
            AmountLabel = new Label();
            button1 = new Button();
            SuspendLayout();
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
            ExitContainer.TabIndex = 11;
            ExitContainer.Text = "X";
            ExitContainer.UseVisualStyleBackColor = false;
            ExitContainer.Click += ExitContainer_Click_1;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 27);
            label1.Name = "label1";
            label1.Size = new Size(316, 25);
            label1.TabIndex = 13;
            label1.Text = "Edit Item";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // ProductTextBox
            // 
            ProductTextBox.BorderStyle = BorderStyle.None;
            ProductTextBox.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductTextBox.Location = new Point(3, 63);
            ProductTextBox.Margin = new Padding(0);
            ProductTextBox.Name = "ProductTextBox";
            ProductTextBox.PlaceholderText = "Enter Product";
            ProductTextBox.Size = new Size(316, 21);
            ProductTextBox.TabIndex = 14;
            ProductTextBox.TextAlign = HorizontalAlignment.Center;
            ProductTextBox.TextChanged += ProductTextBox_TextChanged;
            // 
            // ProductName
            // 
            ProductName.FlatStyle = FlatStyle.Flat;
            ProductName.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductName.Location = new Point(3, 84);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(316, 25);
            ProductName.TabIndex = 15;
            ProductName.Text = "Product Name";
            ProductName.TextAlign = ContentAlignment.MiddleCenter;
            ProductName.Click += ProductName_Click;
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
            AmountTextBox.TabIndex = 16;
            AmountTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AmountLabel
            // 
            AmountLabel.FlatStyle = FlatStyle.Flat;
            AmountLabel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountLabel.Location = new Point(0, 151);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(316, 25);
            AmountLabel.TabIndex = 17;
            AmountLabel.Text = "Amount";
            AmountLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            button1.TabIndex = 18;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // EditControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(button1);
            Controls.Add(AmountLabel);
            Controls.Add(AmountTextBox);
            Controls.Add(ProductName);
            Controls.Add(ProductTextBox);
            Controls.Add(label1);
            Controls.Add(ExitContainer);
            Name = "EditControl";
            Size = new Size(316, 220);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitContainer;
        private Label label1;
        private TextBox ProductTextBox;
        private Label ProductName;
        private TextBox AmountTextBox;
        private Label AmountLabel;
        private Button button1;
    }
}
