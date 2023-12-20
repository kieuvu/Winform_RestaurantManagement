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

namespace RestaurantManagement.Source.Forms.Food
{
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
            this.InitForm();
        }

        private void InitForm()
        {
            this.GetListFoods();
            this.GetListCategory();
            this.GetListUnit();
        }

        private void GetListUnit()
        {
            DataTable dataSource = FoodService.GetListUnit();

            if (dataSource.Rows.Count > 0)
            {
                comboBox1.DataSource = dataSource;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
            }
        }

        private void GetListCategory()
        {
            DataTable dataSource = FoodService.GetListCategory();

            if (dataSource.Rows.Count > 0)
            {
                comboBox2.DataSource = dataSource;
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "id";
            }
        }

        private void GetListFoods()
        {
            DataTable dataSource = FoodService.GetListFoods();

            if (dataSource.Rows.Count > 0)
            {
                listView1.Items.Clear();
                listView1.Columns.Clear();

                Dictionary<string, (string DisplayName, int Width)> columnInfoDictionary = new()
                {
                    { "id", ("ID", 100) },
                    { "name", ("Tên món ăn", 100) },
                    { "price", ("Giá", 100) },
                    { "category_name", ("Loại", 100) },
                    { "unit_name", ("Đơn vị", 100) },
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
                        string key = dataSource.Columns[i].ColumnName;

                        List<string> avoidDisplay = new() { "unit_id", "category_id" };

                        if (avoidDisplay.Contains(key)) continue;

                        if (key == "price")
                        {
                            item.SubItems.Add(StringHelper.ConvertToMoney(row[i].ToString()));
                        }
                        else
                        {
                            item.SubItems.Add(row[i].ToString());
                        }
                    }

                    listView1.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
