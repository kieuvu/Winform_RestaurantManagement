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
                if (radioButton1.Checked)
                {
                    AuthService.LoginAdmin(username, password);

                    this.Hide();

                    Form receptionForm = new ReceptionForm();
                    receptionForm.ShowDialog();

                }
                else
                {
                    AuthService.LoginStaff(username);

                    this.Hide();

                    Form receptionForm = new ReceptionForm();
                    receptionForm.ShowDialog();
                }

                this.Show();
            }
            catch (Exception ex)
            {
                AlertHelper.Show(ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                LoginPassword.Enabled = false;
                LoginPassword.BorderStyle = BorderStyle.FixedSingle;
                label2.ForeColor = Color.Gray;
            }
            else
            {
                LoginPassword.Enabled = true;
                LoginPassword.BorderStyle = BorderStyle.Fixed3D;
                label2.ForeColor = SystemColors.ControlText;
            }
        }
    }
}