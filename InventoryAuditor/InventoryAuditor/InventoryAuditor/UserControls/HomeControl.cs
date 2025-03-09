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
    public partial class HomeControl : UserControl
    {
        //Fetch listView1 from Inventory Control
        int AdequatelyStocked_Value, Stocked_Value, Understocked_Value = 0;
        ListView listview1 = InventoryControl.listView2;

        public HomeControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //It says what it says blud. these counts stocked values
        public void stockedvalues_count()
        {
            AdequatelyStocked_Value = 0;
            Stocked_Value = 0;
            Understocked_Value = 0;
            foreach (ListViewItem item in listview1.Items)
            {
                if (int.TryParse(item.SubItems[2].Text, out int amount) && amount >= 20)
                {
                    AdequatelyStocked_Value++;
                }
                else if (amount < 20 && amount >= 10)
                {
                    Stocked_Value++;
                }
                else
                {
                    Understocked_Value++;
                }

            }

            AdequatelyStockedValue.Text = AdequatelyStocked_Value.ToString();
            StockedValue.Text = Stocked_Value.ToString();
            UnderstockedValue.Text = Understocked_Value.ToString(); 
        }
    }
}
