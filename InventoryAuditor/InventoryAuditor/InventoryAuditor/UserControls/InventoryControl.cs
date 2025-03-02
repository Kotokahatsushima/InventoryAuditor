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
            listView1.View = View.Details;
            addControl1.Hide();
            AddItem("Item 1", "5");
        }
        ListViewItem item = new ListViewItem();
        public void AddItem(string name, string amount)
        {
            item = new ListViewItem();
            item.SubItems.Add(name);
            item.SubItems.Add(amount);
            listView1.Items.Add(item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addControl1.Show();
        }
    }
}
