namespace D7
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPass.Text == "admin")
            {
                MessageBox.Show("welcome admin");
            }
            else
            {
                MessageBox.Show("wrong userName or Password");
            }
        }
    }
}
