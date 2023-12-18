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
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(234, 91);
            button1.TabIndex = 0;
            button1.Text = "Quản lý nhân viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // ReceptionForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(button1);
            this.Name = "ReceptionForm";
            this.Text = "ReceptionForm";
            this.Load += this.ReceptionForm_Load;
            this.ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}