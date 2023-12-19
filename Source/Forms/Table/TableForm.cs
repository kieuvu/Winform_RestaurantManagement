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
            this.GetListTables();
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

        }
    }
}
