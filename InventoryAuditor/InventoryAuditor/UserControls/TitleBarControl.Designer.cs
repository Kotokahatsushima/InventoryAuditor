namespace InventoryAuditor.UserControls
{
    partial class TitleBarControl
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
            ExitButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.White;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            ExitButton.ForeColor = Color.Black;
            ExitButton.Location = new Point(996, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(86, 31);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += EditButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1079, 30);
            label1.TabIndex = 5;
            label1.Text = "Inventory Auditor";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TitleBarControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ExitButton);
            Controls.Add(label1);
            Name = "TitleBarControl";
            Size = new Size(1082, 31);
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Label label1;
    }
}
