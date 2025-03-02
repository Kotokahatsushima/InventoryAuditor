using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryAuditor.UserControls
{
    public partial class AddControl : UserControl
    {
        private InventoryControl inventoryControl;
        public AddControl()
        {
            InitializeComponent();
        }

        private void ExitContainer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inventoryControl.AddItem(ProductTextBox.Text, AmountTextBox.Text);
        }
    }
}
