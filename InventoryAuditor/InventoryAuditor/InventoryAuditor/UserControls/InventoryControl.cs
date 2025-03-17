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
            editControl1.Hide();

            //This will be fetched by other forms
            inventoryControl = this;
            listView2 = this.listView1;
            LoadCSVFile();
        }


        ListViewItem item = new ListViewItem();
        internal static InventoryControl inventoryControl;
        internal static ListView listView2;

        public void AddItem(string name, string amount)
        {
            item = new ListViewItem();
            item.SubItems.Add(name);
            item.SubItems.Add(amount);
            listView1.Items.Add(item);
            MessageBox.Show("Item Added Successfully!", "Add");
        }

        public void EditItem(string name, string amount)
        {
            if (listView1.FocusedItem != null)
            {
                ListViewItem FocusedItem = listView1.FocusedItem;
                FocusedItem.SubItems[1].Text = name;
                FocusedItem.SubItems[2].Text = amount;
                CheckItemState();
            }
            else
            {
                MessageBox.Show("Please select an item to edit", "Edit");
            }
        }
        //Checks if Understocked, stocked properly or Adequately stocked 
        public void CheckItemState()
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (int.TryParse(item.SubItems[2].Text, out int quantity) && quantity >= 20)
                {
                    item.BackColor = Color.FromArgb(75, 97, 209);
                }
                else if (quantity < 20 && quantity >= 10)
                {
                    item.BackColor = Color.FromArgb(96, 209, 75);
                }
                else
                {
                    item.BackColor = Color.FromArgb(209, 75, 75);
                }
            }
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
            if (listView1.FocusedItem != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this item?", "Remove", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    listView1.FocusedItem.Remove();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete", "Delete");
            }
            listView1.Items.Remove(listView1.FocusedItem);
        }

        private void addControl1_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SavetoCSVFile();
        }

        private void SavetoCSVFile()
        {
            using (StreamWriter sw = new StreamWriter("Data.csv"))
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    List<string> columns = new List<string>();
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        columns.Add(subItem.Text);
                    }
                    sw.WriteLine(string.Join(",", columns));
                }
            }
            MessageBox.Show("Data Saved Successfully!", "Save");
        }

        private void LoadCSVFile()
        {
            if (!File.Exists("Data.csv"))
            {
                MessageBox.Show("No Files Saved!");
                return;
            }
            else
            {
                foreach (string line in File.ReadAllLines("Data.csv"))
                {
                    string[] columns = line.Split(',');
                    ListViewItem item = new ListViewItem(columns[0]);
                    for (int i = 1; i < columns.Length; i++)
                    {
                        item.SubItems.Add(columns[i]);
                    }
                    listView1.Items.Add(item);
                }
            }

            //Checks item state for all items loaded from the CSV file  
            foreach (ListViewItem item in listView1.Items)
            {
                CheckItemState();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                ListViewItem FocusedItem = listView1.FocusedItem;
                editControl1.Show();
                editControl1.PlaceHolderChanger();
            }
            else
            {
                MessageBox.Show("Please select an item to edit", "Edit");
            }
        }
    }
}
