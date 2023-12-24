namespace RestaurantManagement.Source.Forms.Booking
{
    partial class BookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            groupBox3 = new GroupBox();
            button1 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            listView2 = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1080, 114);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // button2
            // 
            button2.Location = new Point(861, 30);
            button2.Name = "button2";
            button2.Size = new Size(170, 59);
            button2.TabIndex = 10;
            button2.Text = "Đặt bàn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(612, 71);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 6;
            label5.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 71);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 8;
            label4.Text = "Thời gian";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(630, 66);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(170, 23);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.ValueChanged += this.dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(436, 66);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(170, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += this.dateTimePicker1_ValueChanged;
            dateTimePicker1.BindingContextChanged += this.dateTimePicker1_BindingContextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 35);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "Số lượng";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(436, 32);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 23);
            textBox3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 66);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "Số điện thoại";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên khách hàng";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(listView1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 114);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1080, 123);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin bàn còn trống";
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Top;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(3, 19);
            listView1.Name = "listView1";
            listView1.Size = new Size(1074, 96);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(listView2);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 243);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1080, 345);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Các bàn đã đặt";
            // 
            // button1
            // 
            button1.Location = new Point(993, 23);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 4;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(94, 29);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(81, 23);
            textBox4.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 32);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 2;
            label6.Text = "Lọc theo bàn";
            // 
            // listView2
            // 
            listView2.Dock = DockStyle.Bottom;
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(3, 70);
            listView2.Name = "listView2";
            listView2.Size = new Size(1074, 272);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1080, 588);
            this.Controls.Add(groupBox3);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.Cursor = Cursors.Hand;
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Button button2;
        private GroupBox groupBox2;
        private ListView listView1;
        private GroupBox groupBox3;
        private ListView listView2;
        private Button button1;
        private TextBox textBox4;
        private Label label6;
    }
}