using RestaurantManagement.Source.Forms.Staff;
using RestaurantManagement.Source.Forms.Table;
using RestaurantManagement.Source.Forms.Food;
using RestaurantManagement.Source.Models;
using RestaurantManagement.Source.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagement.Source.Forms.Booking;

namespace RestaurantManagement.Source.Forms.Reception
{
    public partial class ReceptionForm : Form
    {
        public ReceptionForm()
        {
            InitializeComponent();
            this.InitForm();
        }

        private void InitForm()
        {
            this.ShowWelcomeMessage();
            this.HideAdminContent();
        }

        private void ShowWelcomeMessage()
        {
            label2.Text = AuthSession.IsAdmin()
                       ? $"{AuthSession.Username} (ADMIN)!"
                       : $"{AuthSession.Username} ({StringHelper.PadNumberWithZeros(AuthSession.Id)})!";
        }

        private void HideAdminContent()
        {
            if (AuthSession.IsStaff())
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form staff = new StaffForm();
            staff.ShowDialog();

            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form table = new TableForm();
            table.ShowDialog();

            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form food = new FoodForm();
            food.ShowDialog();

            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form booking = new BookingForm();
            booking.ShowDialog();

            this.Show();
        }
    }
}
