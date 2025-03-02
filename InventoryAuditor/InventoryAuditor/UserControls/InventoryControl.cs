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
    public partial class InventoryControl : UserControl
    {
        public InventoryControl()
        {
            InitializeComponent();
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.HideSelection = false; // Ensure items remain highlighted
            listView1.View = View.Details;
            addControl1.Hide();
            AddItem("Item 1", "5");
            inventoryControl = this;
        }


        ListViewItem item = new ListViewItem();
        internal static InventoryControl inventoryControl;

        public void AddItem(string name, string amount)
        {
            item = new ListViewItem();
            item.SubItems.Add(name);
            item.SubItems.Add(amount);
            listView1.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addControl1.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Perform actions with the selected item
                // For example, highlight the item
                selectedItem.Selected = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.FocusedItem);
        }

        private void addControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
