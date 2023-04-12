
namespace TouristCompany.WinForms
{
    partial class AddEditHotelForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.addServ_btn = new System.Windows.Forms.Button();
            this.hotelServices_dgv = new System.Windows.Forms.DataGridView();
            this.rating_numeric = new System.Windows.Forms.NumericUpDown();
            this.info_txbx = new System.Windows.Forms.TextBox();
            this.city_txbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.service_cmbx = new System.Windows.Forms.ComboBox();
            this.country_cmbx = new System.Windows.Forms.ComboBox();
            this.hotelName_txbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelServices_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rating_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // ok_btn
            // 
            this.ok_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ok_btn.Location = new System.Drawing.Point(299, 378);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 34);
            this.ok_btn.TabIndex = 26;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_btn.Location = new System.Drawing.Point(380, 378);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(89, 34);
            this.cancel_btn.TabIndex = 25;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // addServ_btn
            // 
            this.addServ_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addServ_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addServ_btn.Location = new System.Drawing.Point(359, 224);
            this.addServ_btn.Name = "addServ_btn";
            this.addServ_btn.Size = new System.Drawing.Size(32, 24);
            this.addServ_btn.TabIndex = 24;
            this.addServ_btn.Text = "+";
            this.addServ_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addServ_btn.UseVisualStyleBackColor = true;
            this.addServ_btn.Click += new System.EventHandler(this.addServ_btn_Click);
            // 
            // hotelServices_dgv
            // 
            this.hotelServices_dgv.AllowUserToAddRows = false;
            this.hotelServices_dgv.AllowUserToDeleteRows = false;
            this.hotelServices_dgv.AllowUserToResizeColumns = false;
            this.hotelServices_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.hotelServices_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.hotelServices_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hotelServices_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hotelServices_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelServices_dgv.Location = new System.Drawing.Point(95, 253);
            this.hotelServices_dgv.Name = "hotelServices_dgv";
            this.hotelServices_dgv.ReadOnly = true;
            this.hotelServices_dgv.RowHeadersVisible = false;
            this.hotelServices_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hotelServices_dgv.Size = new System.Drawing.Size(374, 112);
            this.hotelServices_dgv.TabIndex = 23;
            // 
            // rating_numeric
            // 
            this.rating_numeric.Location = new System.Drawing.Point(95, 120);
            this.rating_numeric.Name = "rating_numeric";
            this.rating_numeric.Size = new System.Drawing.Size(120, 20);
            this.rating_numeric.TabIndex = 22;
            // 
            // info_txbx
            // 
            this.info_txbx.Location = new System.Drawing.Point(95, 156);
            this.info_txbx.Multiline = true;
            this.info_txbx.Name = "info_txbx";
            this.info_txbx.Size = new System.Drawing.Size(374, 62);
            this.info_txbx.TabIndex = 20;
            // 
            // city_txbx
            // 
            this.city_txbx.Location = new System.Drawing.Point(95, 85);
            this.city_txbx.Name = "city_txbx";
            this.city_txbx.Size = new System.Drawing.Size(374, 20);
            this.city_txbx.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "(0-100)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Услуги:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Информация:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Райтинг:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Город:";
            // 
            // service_cmbx
            // 
            this.service_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.service_cmbx.FormattingEnabled = true;
            this.service_cmbx.Location = new System.Drawing.Point(95, 226);
            this.service_cmbx.Name = "service_cmbx";
            this.service_cmbx.Size = new System.Drawing.Size(258, 21);
            this.service_cmbx.TabIndex = 14;
            // 
            // country_cmbx
            // 
            this.country_cmbx.FormattingEnabled = true;
            this.country_cmbx.Location = new System.Drawing.Point(95, 51);
            this.country_cmbx.Name = "country_cmbx";
            this.country_cmbx.Size = new System.Drawing.Size(244, 21);
            this.country_cmbx.TabIndex = 13;
            // 
            // hotelName_txbx
            // 
            this.hotelName_txbx.Location = new System.Drawing.Point(95, 18);
            this.hotelName_txbx.Name = "hotelName_txbx";
            this.hotelName_txbx.Size = new System.Drawing.Size(374, 20);
            this.hotelName_txbx.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Страна:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название отеля:";
            // 
            // AddEditHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 430);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.addServ_btn);
            this.Controls.Add(this.hotelServices_dgv);
            this.Controls.Add(this.rating_numeric);
            this.Controls.Add(this.info_txbx);
            this.Controls.Add(this.city_txbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.service_cmbx);
            this.Controls.Add(this.country_cmbx);
            this.Controls.Add(this.hotelName_txbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditHotelForm";
            this.Text = "Добавить\\Изменить Отель";
            this.Load += new System.EventHandler(this.AddEditHotelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelServices_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rating_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button addServ_btn;
        private System.Windows.Forms.DataGridView hotelServices_dgv;
        private System.Windows.Forms.NumericUpDown rating_numeric;
        private System.Windows.Forms.TextBox info_txbx;
        private System.Windows.Forms.TextBox city_txbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox service_cmbx;
        private System.Windows.Forms.ComboBox country_cmbx;
        private System.Windows.Forms.TextBox hotelName_txbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}