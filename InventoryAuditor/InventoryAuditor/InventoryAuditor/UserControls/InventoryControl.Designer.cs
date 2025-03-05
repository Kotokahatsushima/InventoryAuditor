namespace InventoryAuditor.UserControls
{
    partial class InventoryControl
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
            Title = new Label();
            listView1 = new ListView();
            nullColumn = new ColumnHeader();
            ProductColumn = new ColumnHeader();
            AmountColumn = new ColumnHeader();
            EditButton = new Button();
            button1 = new Button();
            button2 = new Button();
            addControl1 = new AddControl();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.Black;
            Title.Location = new Point(0, 0);
            Title.Margin = new Padding(0);
            Title.Name = "Title";
            Title.Size = new Size(177, 74);
            Title.TabIndex = 1;
            Title.Text = "Inventory";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            listView1.BackColor = Color.SeaShell;
            listView1.Columns.AddRange(new ColumnHeader[] { nullColumn, ProductColumn, AmountColumn });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(26, 77);
            listView1.Name = "listView1";
            listView1.Size = new Size(846, 351);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // nullColumn
            // 
            nullColumn.Width = 0;
            // 
            // ProductColumn
            // 
            ProductColumn.Text = "Product";
            ProductColumn.TextAlign = HorizontalAlignment.Center;
            ProductColumn.Width = 300;
            // 
            // AmountColumn
            // 
            AmountColumn.Text = "Amount";
            AmountColumn.TextAlign = HorizontalAlignment.Center;
            AmountColumn.Width = 100;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.FromArgb(75, 97, 209);
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(564, 30);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 41);
            EditButton.TabIndex = 3;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(96, 209, 75);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(669, 30);
            button1.Name = "button1";
            button1.Size = new Size(94, 41);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(209, 75, 75);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(774, 30);
            button2.Name = "button2";
            button2.Size = new Size(94, 41);
            button2.TabIndex = 5;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // addControl1
            // 
            addControl1.BackColor = Color.White;
            addControl1.Location = new Point(264, 162);
            addControl1.Name = "addControl1";
            addControl1.Size = new Size(316, 220);
            addControl1.TabIndex = 6;
            addControl1.Load += addControl1_Load;
            // 
            // InventoryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(addControl1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(EditButton);
            Controls.Add(listView1);
            Controls.Add(Title);
            Name = "InventoryControl";
            Size = new Size(894, 446);
            ResumeLayout(false);
        }

        #endregion

        private Label Title;
        private ListView listView1;
        private ColumnHeader nullColumn;
        private ColumnHeader ProductColumn;
        private ColumnHeader AmountColumn;
        private Button EditButton;
        private Button button1;
        private Button button2;
        private AddControl addControl1;
    }
}
