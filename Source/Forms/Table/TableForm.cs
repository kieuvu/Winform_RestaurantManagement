using MySqlX.XDevAPI.Common;
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

namespace RestaurantManagement.Source.Forms.Table
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
            this.InitForm();
        }

        private void InitForm()
        {
            this.InitCombobox();
            this.GetListTables();
        }

        private void InitCombobox()
        {
            comboBox1.Items.AddRange(new object[] { 1, 2, 3, 4 });

            comboBox1.SelectedIndex = 0;

            comboBox2.Items.AddRange(new object[] { 2, 4, 6, 8, 10 });

            comboBox2.SelectedIndex = 0;
        }

        private void GetListTables()
        {
            DataTable dataSource = TableService.GetListTables();

            if (dataSource.Rows.Count > 0)
            {
                listView1.Items.Clear();
                listView1.Columns.Clear();

                Dictionary<string, (string DisplayName, int Width)> columnInfoDictionary = new()
                {
                    { "id", ("ID", 100) },
                    { "quantity", ("Số người", 100) },
                    { "price", ("Giá/Giờ", 100) },
                    { "floor", ("Tầng", 100) },       
                };

                foreach (KeyValuePair<string, (string DisplayName, int Width)> columnInfo in columnInfoDictionary)
                {

                    if (!dataSource.Columns.Contains(columnInfo.Key)) continue;
                    listView1.Columns.Add(columnInfo.Value.DisplayName, columnInfo.Value.Width);
                }

                foreach (DataRow row in dataSource.Rows)
                {
                    ListViewItem item = new(StringHelper.PadNumberWithZeros(row[0]));

                    for (int i = 1; i < dataSource.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }

                    listView1.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string price = textBox1.Text;
                int floor = Convert.ToInt32(comboBox1.SelectedItem);
                int quantity = Convert.ToInt32(comboBox2.SelectedItem);

                int result = TableService.CreateTable(price, quantity, floor);

                if (result > 0)
                {
                    AlertHelper.Show("Thêm thành công");
                    this.GetListTables();
                }
            }
            catch (Exception ex) 
            {
                AlertHelper.Show(ex.Message);
            }
        }
    }
}
