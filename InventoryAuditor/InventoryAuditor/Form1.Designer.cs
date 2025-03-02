namespace InventoryAuditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            InventoryButton = new Button();
            HomeButton = new Button();
            panel2 = new Panel();
            TitleActive = new Label();
            panel3 = new Panel();
            inventoryControl1 = new InventoryAuditor.UserControls.InventoryControl();
            titleBarControl1 = new InventoryAuditor.UserControls.TitleBarControl();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(96, 209, 75);
            panel1.Controls.Add(InventoryButton);
            panel1.Controls.Add(HomeButton);
            panel1.Location = new Point(0, 30);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 491);
            panel1.TabIndex = 0;
            // 
            // InventoryButton
            // 
            InventoryButton.Dock = DockStyle.Top;
            InventoryButton.FlatAppearance.BorderSize = 0;
            InventoryButton.FlatStyle = FlatStyle.Flat;
            InventoryButton.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InventoryButton.ForeColor = Color.White;
            InventoryButton.Location = new Point(0, 77);
            InventoryButton.Name = "InventoryButton";
            InventoryButton.Size = new Size(188, 77);
            InventoryButton.TabIndex = 1;
            InventoryButton.Text = "Inventory";
            InventoryButton.UseVisualStyleBackColor = true;
            InventoryButton.Click += InventoryButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.Dock = DockStyle.Top;
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeButton.ForeColor = Color.White;
            HomeButton.Location = new Point(0, 0);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(188, 77);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(96, 209, 75);
            panel2.Controls.Add(TitleActive);
            panel2.Location = new Point(188, 30);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 45);
            panel2.TabIndex = 1;
            // 
            // TitleActive
            // 
            TitleActive.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleActive.ForeColor = Color.White;
            TitleActive.Location = new Point(0, 0);
            TitleActive.Margin = new Padding(0);
            TitleActive.Name = "TitleActive";
            TitleActive.Size = new Size(894, 45);
            TitleActive.TabIndex = 0;
            TitleActive.Text = "Home";
            TitleActive.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(inventoryControl1);
            panel3.Location = new Point(188, 75);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(894, 446);
            panel3.TabIndex = 2;
            // 
            // inventoryControl1
            // 
            inventoryControl1.BackColor = Color.White;
            inventoryControl1.Location = new Point(0, 0);
            inventoryControl1.Name = "inventoryControl1";
            inventoryControl1.Size = new Size(894, 446);
            inventoryControl1.TabIndex = 0;
            inventoryControl1.Load += inventoryControl1_Load;
            // 
            // titleBarControl1
            // 
            titleBarControl1.BackColor = Color.White;
            titleBarControl1.Location = new Point(0, -2);
            titleBarControl1.Margin = new Padding(0);
            titleBarControl1.Name = "titleBarControl1";
            titleBarControl1.Size = new Size(1082, 32);
            titleBarControl1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1080, 519);
            ControlBox = false;
            Controls.Add(titleBarControl1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Auditor";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button InventoryButton;
        private Button HomeButton;
        private Panel panel2;
        private Label TitleActive;
        private Panel panel3;
        private UserControls.TitleBarControl titleBarControl1;
        public UserControls.InventoryControl inventoryControl1;
    }
}
