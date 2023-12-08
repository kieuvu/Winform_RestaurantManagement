using MySql.Data.MySqlClient;
using RestaurantManagement.Source.Forms.Reception;
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
                AuthService.Login(username, password);

                this.Hide();

                Form receptionForm = new ReceptionForm();
                receptionForm.ShowDialog();

                this.Show();
            }
            catch (Exception ex)
            {
                AlertHelper.Show(ex.Message);
            }
        }
    }
}