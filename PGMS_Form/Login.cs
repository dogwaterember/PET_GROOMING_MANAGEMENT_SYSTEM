namespace PGMS_Form
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            using (var dashboard = new UserDashboard())
            {
                dashboard.ShowDialog();
            }
            Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
