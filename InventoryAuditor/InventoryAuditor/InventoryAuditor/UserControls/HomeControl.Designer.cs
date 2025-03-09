namespace InventoryAuditor.UserControls
{
    partial class HomeControl
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            AdequatelyStockedValue = new Label();
            StockedValue = new Label();
            label3 = new Label();
            UnderstockedValue = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            Title.TabIndex = 2;
            Title.Text = "Home";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 97, 209);
            panel1.Controls.Add(AdequatelyStockedValue);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(86, 74);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 148);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(96, 209, 75);
            panel2.Controls.Add(StockedValue);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(435, 74);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 148);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(209, 75, 75);
            panel3.Controls.Add(UnderstockedValue);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(86, 260);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(662, 148);
            panel3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 75, 97, 209);
            label1.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 92);
            label1.Name = "label1";
            label1.Size = new Size(262, 30);
            label1.TabIndex = 0;
            label1.Text = "Adequately Stocked";
            label1.Click += label1_Click;
            // 
            // AdequatelyStockedValue
            // 
            AdequatelyStockedValue.AutoSize = true;
            AdequatelyStockedValue.BackColor = Color.FromArgb(0, 75, 97, 209);
            AdequatelyStockedValue.Font = new Font("Tahoma", 30F, FontStyle.Bold);
            AdequatelyStockedValue.ForeColor = Color.White;
            AdequatelyStockedValue.Location = new Point(34, 32);
            AdequatelyStockedValue.Name = "AdequatelyStockedValue";
            AdequatelyStockedValue.Size = new Size(57, 60);
            AdequatelyStockedValue.TabIndex = 1;
            AdequatelyStockedValue.Text = "0";
            // 
            // StockedValue
            // 
            StockedValue.AutoSize = true;
            StockedValue.BackColor = Color.FromArgb(0, 75, 97, 209);
            StockedValue.Font = new Font("Tahoma", 30F, FontStyle.Bold);
            StockedValue.ForeColor = Color.White;
            StockedValue.Location = new Point(38, 32);
            StockedValue.Name = "StockedValue";
            StockedValue.Size = new Size(57, 60);
            StockedValue.TabIndex = 3;
            StockedValue.Text = "0";
            StockedValue.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 75, 97, 209);
            label3.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 92);
            label3.Name = "label3";
            label3.Size = new Size(113, 30);
            label3.TabIndex = 2;
            label3.Text = "Stocked";
            // 
            // UnderstockedValue
            // 
            UnderstockedValue.AutoSize = true;
            UnderstockedValue.BackColor = Color.FromArgb(0, 75, 97, 209);
            UnderstockedValue.Font = new Font("Tahoma", 30F, FontStyle.Bold);
            UnderstockedValue.ForeColor = Color.White;
            UnderstockedValue.Location = new Point(34, 41);
            UnderstockedValue.Name = "UnderstockedValue";
            UnderstockedValue.Size = new Size(57, 60);
            UnderstockedValue.TabIndex = 3;
            UnderstockedValue.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 75, 97, 209);
            label5.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 101);
            label5.Name = "label5";
            label5.Size = new Size(186, 30);
            label5.TabIndex = 2;
            label5.Text = "Understocked";
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Title);
            Name = "HomeControl";
            Size = new Size(894, 446);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Title;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label AdequatelyStockedValue;
        private Label StockedValue;
        private Label label3;
        private Label UnderstockedValue;
        private Label label5;
    }
}
