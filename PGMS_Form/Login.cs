namespace PGMS_Form
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using (var dashboard = new AdminDashboard())
            {
                dashboard.ShowDialog();
            }
            Show();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using (var dashboard = new UserDashboard())
            {
                dashboard.ShowDialog();
            }
            Show();
        }
    }
}
