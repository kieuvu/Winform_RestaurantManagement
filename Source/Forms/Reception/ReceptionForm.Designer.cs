namespace RestaurantManagement.Source.Forms.Reception
{
    partial class ReceptionForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            button4 = new Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(274, 73);
            button1.Name = "button1";
            button1.Size = new Size(252, 91);
            button1.TabIndex = 0;
            button1.Text = "Quản lý nhân viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(12, 73);
            button2.Name = "button2";
            button2.Size = new Size(251, 91);
            button2.TabIndex = 1;
            button2.Text = "Quản lý bàn ăn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(537, 73);
            button3.Name = "button3";
            button3.Size = new Size(251, 91);
            button3.TabIndex = 2;
            button3.Text = "Quản lý món ăn";
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 3;
            label1.Text = "Xin chào";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 20);
            label2.Name = "label2";
            label2.Size = new Size(54, 32);
            label2.TabIndex = 4;
            label2.Text = "____";
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(12, 191);
            button4.Name = "button4";
            button4.Size = new Size(251, 91);
            button4.TabIndex = 5;
            button4.Text = "Đặt bàn";
            button4.UseVisualStyleBackColor = true;
            button4.Click += this.button4_Click;
            // 
            // ReceptionForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1008, 450);
            this.Controls.Add(button4);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Name = "ReceptionForm";
            this.Text = "ReceptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Button button4;
    }
}