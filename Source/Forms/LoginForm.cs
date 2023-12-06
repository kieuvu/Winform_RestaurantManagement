using RestaurantManagement.Source.Services;

namespace RestaurantManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void LoginHandlerButton_Click(object sender, EventArgs e)
        {
            string username = LoginUsername.Text;
            string password = LoginPassword.Text;

            string result = AuthService.Login(username, password);

            MessageBox.Show(Text, result);
        }
    }
}