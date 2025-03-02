using InventoryAuditor.UserControls;
using System.ComponentModel;

namespace InventoryAuditor
{
    public partial class Form1 : Form
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static Form1 Instance { get; private set; } // Singleton reference
        public InventoryControl inventoryControl => inventoryControl1; // Public property
        public Form1()
        {
            Instance = this;  // Assign instance
            InitializeComponent();
            inventoryControl1.Hide();
        }
        
        private void InventoryButton_Click(object sender, EventArgs e)
        {
            TitleActive.Text = "Inventory";
            inventoryControl1.Show();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            TitleActive.Text = "Home";
            inventoryControl1.Hide();
        }

        private void inventoryControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
