namespace InventoryAuditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
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
