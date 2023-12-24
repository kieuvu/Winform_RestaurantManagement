using Org.BouncyCastle.Tls;
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

namespace RestaurantManagement.Source.Forms.Booking
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
            this.InitForm();
        }

        private void InitForm()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm";

            this.GetListBooking();
        }

        private void GetListBooking()
        {
            DataTable dataSource = BookingService.GetAllBookings();

            if (dataSource.Rows.Count > 0)
            {
                listView2.Items.Clear();
                listView2.Columns.Clear();

                Dictionary<string, (string DisplayName, int Width)> columnInfoDictionary = new()
                {
                    { "customer_name", ("Tên khách hàng", 150) },
                    { "customer_phone", ("Số điện thọai", 150) },
                    { "booking_from", ("Từ", 150) },
                    { "booking_to", ("Đến", 150) },
                    { "quantity", ("Số người", 100) },
                    { "table_id", ("Bàn", 100) },
                    { "floor", ("Tầng", 100) },
                };

                foreach (KeyValuePair<string, (string DisplayName, int Width)> columnInfo in columnInfoDictionary)
                {
                    if (!dataSource.Columns.Contains(columnInfo.Key)) continue;
                    listView2.Columns.Add(columnInfo.Value.DisplayName, columnInfo.Value.Width);
                }

                foreach (DataRow row in dataSource.Rows)
                {
                    ListViewItem item = new(row[0].ToString());

                    for (int i = 1; i < dataSource.Columns.Count; i++)
                    {
                        string key = dataSource.Columns[i].ColumnName;

                        if (key == "table_id")
                        {
                            item.SubItems.Add(StringHelper.PadNumberWithZeros(row[i].ToString()));
                        }
                        else
                        {
                            item.SubItems.Add(row[i].ToString());
                        }
                    }

                    listView2.Items.Add(item);
                }
            }
        }

        private void LoadUnbookedTable(string? from = null, string? to = null)
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:m:ss");

            if (from is null || to is null)
            {
                from = currentDate;
                to = currentDate;
            }
            else
            {
                from = DateTime.Parse(from).ToString("yyyy-MM-dd HH:m:ss");
                to = DateTime.Parse(to).ToString("yyyy-MM-dd HH:m:ss");
            }

            DataTable dataSource = TableService.GetUnbookedTableBetweenDate(from, to);

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
                        string key = dataSource.Columns[i].ColumnName;

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

        private void button2_Click(object sender, EventArgs e)
        {
            string customerName = textBox1.Text;
            string customerPhone = textBox2.Text;
            int quantity = Convert.ToInt32(textBox3.Text);
            string bookingFrom = dateTimePicker1.Text;
            string bookingTo = dateTimePicker2.Text;

            if (listView1.SelectedItems.Count == 0)
            {
                AlertHelper.Show("Vui lòng chọn bàn");
                return;
            }

            ListViewItem selectedItem = listView1.SelectedItems[0];

            int selectedTable = Convert.ToInt32(selectedItem.SubItems[0].Text);

            int result = BookingService.CreateBooking(customerName, customerPhone, bookingFrom, bookingTo, selectedTable, quantity);

            if (result > 0)
            {
                AlertHelper.Show("Đặt bàn thành công");
                this.LoadUnbookedTable(bookingFrom, bookingTo);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void dateTimePicker1_BindingContextChanged(object sender, EventArgs e)
        {
            string bookingFrom = dateTimePicker1.Text;
            string bookingTo = dateTimePicker2.Text;

            this.LoadUnbookedTable(bookingFrom, bookingTo);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string bookingFrom = dateTimePicker1.Text;
            string bookingTo = dateTimePicker2.Text;

            this.LoadUnbookedTable(bookingFrom, bookingTo);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string bookingFrom = dateTimePicker1.Text;
            string bookingTo = dateTimePicker2.Text;

            this.LoadUnbookedTable(bookingFrom, bookingTo);
        }
    }
}
