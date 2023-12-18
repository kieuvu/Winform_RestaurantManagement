using RestaurantManagement.Source.Services;
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

namespace RestaurantManagement.Source.Forms.Staff
{
    public partial class StaffForm : Form
    {
        private static bool isStaffPositionGot = false;

        public StaffForm()
        {
            InitializeComponent();
            this.InitForm();
        }

        private void InitForm()
        {
            this.GetListStaffPosition();
           // this.GetListStaffs();
        }

        private void GetListStaffPosition()
        {
            DataTable dataSource = StaffService.GetListStaffPosition();

            if (dataSource.Rows.Count > 0)
            {
                comboBox1.DataSource = dataSource;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
            }
        }

        private void GetListStaffs()
        {
            DataTable dataSource = StaffService.GetListStaffs();

            if (dataSource.Rows.Count > 0)
            {
                dataGridView1.DataSource = dataSource;
                dataGridView1.CellFormatting += this.DataGridView1_CellFormatting;

                dataGridView1.Columns["position_id"].Visible = false;
                dataGridView1.Columns["id"].Visible = false;

                dataGridView1.Columns["name"].HeaderText = "Tên nhân viên";
                dataGridView1.Columns["dob"].HeaderText = "Ngày sinh";
                dataGridView1.Columns["gender"].HeaderText = "Giới tính";
                dataGridView1.Columns["salary"].HeaderText = "Lương";
                dataGridView1.Columns["join_date"].HeaderText = "Ngày vào làm";
                dataGridView1.Columns["phone"].HeaderText = "Số điện thoại";
                dataGridView1.Columns["address"].HeaderText = "Nơi ở";
                dataGridView1.Columns["email"].HeaderText = "Email";
                dataGridView1.Columns["position_name"].HeaderText = "Vị trí";
            }
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["gender"].Index && e.Value != null)
            {
                int genderValue = Convert.ToInt32(e.Value);
                e.Value = (genderValue == 1) ? "Nữ" : ((genderValue == 2) ? "Nam" : "Khác");
                e.FormattingApplied = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox6.Text;
            int gender = radioButton1.Checked ? 2 : 1;
            string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string joinDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string email = textBox1.Text;
            string phone= textBox2.Text;
            string address= textBox3.Text;
            int position = Convert.ToInt32(comboBox1.SelectedValue);
            MessageBox.Show(position.ToString());
           // int salary = Convert.ToInt32(textBox5.Text);
        }
    }
}
