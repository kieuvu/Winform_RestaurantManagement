using RestaurantManagement.Source.Forms.Staff;
using RestaurantManagement.Source.Forms.Table;
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

namespace RestaurantManagement.Source.Forms.Reception
{
    public partial class ReceptionForm : Form
    {
        public ReceptionForm()
        {
            InitializeComponent();
        }

        private void ReceptionForm_Load(object sender, EventArgs e)
        {
            AlertHelper.Show(AuthSession.Username);
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
    }
}
