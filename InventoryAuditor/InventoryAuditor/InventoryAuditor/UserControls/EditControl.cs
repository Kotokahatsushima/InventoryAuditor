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
    public partial class EditControl : UserControl
    {
        InventoryControl inventoryControl = InventoryControl.inventoryControl;
        
        public EditControl()
        {
            InitializeComponent();
        }
        
        public void PlaceHolderChanger()
        {
            try
            {
                ListView listView1 = InventoryControl.listView2;
                ListViewItem FocusedlistView1 = listView1.FocusedItem;
                ProductTextBox.PlaceholderText = FocusedlistView1.SubItems[1].Text;
            }
            catch
            {
                ProductTextBox.PlaceholderText = "Please select an item to edit";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ExitContainer_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ProductName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Fetches inventoryControl1 instance from the inventorycontrol form. just kys if this ain't work
            InventoryControl inventoryControl = InventoryControl.inventoryControl;

            //If this try is successful, we ball
            try
            {
                int AmountTextBoxConvert = Convert.ToInt32(AmountTextBox.Text);
                if (ProductTextBox.Text == "")
                {
                    ListView listView1 = InventoryControl.listView2;
                    ListViewItem FocusedlistView1 = listView1.FocusedItem;
                    inventoryControl.EditItem(FocusedlistView1.SubItems[1].Text, AmountTextBox.Text);
                }
                else
                {
                    inventoryControl.EditItem(ProductTextBox.Text, AmountTextBox.Text);
                }
                ProductTextBox.Text = "";
                AmountTextBox.Text = "";
                AmountLabel.Text = "Amount";
                this.Hide();
                MessageBox.Show("Item Edited", "Edit", MessageBoxButtons.OK);
                inventoryControl.CheckItemState();
            }


            //If failed, it does this thingy
            catch
            {
                AmountLabel.Text = "Please Enter Valid Amount";
            }
        }
    }
}
