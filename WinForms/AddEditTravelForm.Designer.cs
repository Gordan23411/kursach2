
namespace TouristCompany.WinForms
{
    partial class AddEditTravelForm
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
            this.tour_cmbx = new System.Windows.Forms.ComboBox();
            this.tourist_cmbx = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.discounted_num = new System.Windows.Forms.NumericUpDown();
            this.cost_num = new System.Windows.Forms.NumericUpDown();
            this.fare_num = new System.Windows.Forms.NumericUpDown();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.discounted_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fare_num)).BeginInit();
            this.SuspendLayout();
            // 
            // tour_cmbx
            // 
            this.tour_cmbx.FormattingEnabled = true;
            this.tour_cmbx.Location = new System.Drawing.Point(130, 49);
            this.tour_cmbx.Name = "tour_cmbx";
            this.tour_cmbx.Size = new System.Drawing.Size(162, 21);
            this.tour_cmbx.TabIndex = 17;
            this.tour_cmbx.SelectedIndexChanged += new System.EventHandler(this.tour_cmbx_SelectedIndexChanged);
            // 
            // tourist_cmbx
            // 
            this.tourist_cmbx.FormattingEnabled = true;
            this.tourist_cmbx.Location = new System.Drawing.Point(130, 21);
            this.tourist_cmbx.Name = "tourist_cmbx";
            this.tourist_cmbx.Size = new System.Drawing.Size(162, 21);
            this.tourist_cmbx.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // discounted_num
            // 
            this.discounted_num.Location = new System.Drawing.Point(130, 149);
            this.discounted_num.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.discounted_num.Name = "discounted_num";
            this.discounted_num.Size = new System.Drawing.Size(162, 20);
            this.discounted_num.TabIndex = 13;
            // 
            // cost_num
            // 
            this.cost_num.Location = new System.Drawing.Point(130, 116);
            this.cost_num.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cost_num.Name = "cost_num";
            this.cost_num.ReadOnly = true;
            this.cost_num.Size = new System.Drawing.Size(162, 20);
            this.cost_num.TabIndex = 14;
            // 
            // fare_num
            // 
            this.fare_num.Location = new System.Drawing.Point(130, 83);
            this.fare_num.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.fare_num.Name = "fare_num";
            this.fare_num.Size = new System.Drawing.Size(162, 20);
            this.fare_num.TabIndex = 15;
            // 
            // cancel_btn
            // 
            this.cancel_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_btn.Location = new System.Drawing.Point(188, 220);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(104, 34);
            this.cancel_btn.TabIndex = 11;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ok_btn.Location = new System.Drawing.Point(78, 220);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(104, 34);
            this.ok_btn.TabIndex = 12;
            this.ok_btn.Text = "Ок";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата заезда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Скидка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Стоимость тура";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Плата за проезд";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Турист";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Тур";
            // 
            // AddEditTravelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 274);
            this.Controls.Add(this.tour_cmbx);
            this.Controls.Add(this.tourist_cmbx);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.discounted_num);
            this.Controls.Add(this.cost_num);
            this.Controls.Add(this.fare_num);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditTravelForm";
            this.Text = "Путешествие";
            this.Load += new System.EventHandler(this.AddEditTravelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.discounted_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fare_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tour_cmbx;
        private System.Windows.Forms.ComboBox tourist_cmbx;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown discounted_num;
        private System.Windows.Forms.NumericUpDown cost_num;
        private System.Windows.Forms.NumericUpDown fare_num;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}