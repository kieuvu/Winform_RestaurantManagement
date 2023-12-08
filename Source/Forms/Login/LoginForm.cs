using MySql.Data.MySqlClient;
using RestaurantManagement.Source.Services;
using RestaurantManagement.Source.Utils;

namespace RestaurantManagement.Source.Forms.Login
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

            try
            {
                LoginFormHelpers.ValidateLoginForm(username, password);
                string result = AuthService.Login(username, password);
            }
            catch (Exception ex)
            {
                AlertHelper.Show(ex.Message);
            }
        }
    }
}