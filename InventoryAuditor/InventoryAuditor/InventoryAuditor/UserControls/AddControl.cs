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
        public AddControl()
        {
            InitializeComponent();
        }

        private void ExitContainer_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductTextBox.Text = "";
            AmountTextBox.Text = "";
            AmountLabel.Text = "Amount";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Fetches inventoryControl1 instance from the inventorycontrol form. just kys if this ain't work
            InventoryControl inventoryControl = InventoryControl.inventoryControl;

            //If this try is successful, we ball
            try
            {
                int AmountTextBoxConvert = Convert.ToInt32(AmountTextBox.Text);
                inventoryControl.AddItem(ProductTextBox.Text, AmountTextBox.Text);
                ProductTextBox.Text = "";
                AmountTextBox.Text = "";
                AmountLabel.Text = "Amount";
            }


            //If failed, it does this thingy
            catch
            {
                AmountLabel.Text = "Please Enter Valid Amount";
            }

        }

        private void ProductName_Click(object sender, EventArgs e)
        {

        }
    }
}
