
namespace TouristCompany.WinForms
{
    partial class AddEditTourForm
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
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.seats_numeric = new System.Windows.Forms.NumericUpDown();
            this.price_numeric = new System.Windows.Forms.NumericUpDown();
            this.dateend_dtpc = new System.Windows.Forms.DateTimePicker();
            this.dateBegin_dtpc = new System.Windows.Forms.DateTimePicker();
            this.hotel_cmbx = new System.Windows.Forms.ComboBox();
            this.country_cmbx = new System.Windows.Forms.ComboBox();
            this.information_numeric = new System.Windows.Forms.TextBox();
            this.tourname_txbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seats_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // ok_btn
            // 
            this.ok_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ok_btn.Location = new System.Drawing.Point(367, 403);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 34);
            this.ok_btn.TabIndex = 28;
            this.ok_btn.Text = "Ок";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_btn.Location = new System.Drawing.Point(448, 403);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(89, 34);
            this.cancel_btn.TabIndex = 29;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // seats_numeric
            // 
            this.seats_numeric.Location = new System.Drawing.Point(153, 210);
            this.seats_numeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.seats_numeric.Name = "seats_numeric";
            this.seats_numeric.Size = new System.Drawing.Size(384, 20);
            this.seats_numeric.TabIndex = 27;
            // 
            // price_numeric
            // 
            this.price_numeric.Location = new System.Drawing.Point(153, 175);
            this.price_numeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.price_numeric.Name = "price_numeric";
            this.price_numeric.Size = new System.Drawing.Size(384, 20);
            this.price_numeric.TabIndex = 26;
            // 
            // dateend_dtpc
            // 
            this.dateend_dtpc.Location = new System.Drawing.Point(153, 141);
            this.dateend_dtpc.Name = "dateend_dtpc";
            this.dateend_dtpc.Size = new System.Drawing.Size(384, 20);
            this.dateend_dtpc.TabIndex = 25;
            this.dateend_dtpc.Value = new System.DateTime(2021, 3, 26, 11, 49, 0, 0);
            this.dateend_dtpc.ValueChanged += new System.EventHandler(this.dateend_dtpc_ValueChanged);
            // 
            // dateBegin_dtpc
            // 
            this.dateBegin_dtpc.Location = new System.Drawing.Point(153, 106);
            this.dateBegin_dtpc.Name = "dateBegin_dtpc";
            this.dateBegin_dtpc.Size = new System.Drawing.Size(384, 20);
            this.dateBegin_dtpc.TabIndex = 24;
            this.dateBegin_dtpc.Value = new System.DateTime(2010, 3, 26, 11, 49, 0, 0);
            this.dateBegin_dtpc.ValueChanged += new System.EventHandler(this.dateBegin_dtpc_ValueChanged);
            // 
            // hotel_cmbx
            // 
            this.hotel_cmbx.FormattingEnabled = true;
            this.hotel_cmbx.Location = new System.Drawing.Point(153, 75);
            this.hotel_cmbx.Name = "hotel_cmbx";
            this.hotel_cmbx.Size = new System.Drawing.Size(384, 21);
            this.hotel_cmbx.TabIndex = 22;
            // 
            // country_cmbx
            // 
            this.country_cmbx.FormattingEnabled = true;
            this.country_cmbx.Location = new System.Drawing.Point(153, 42);
            this.country_cmbx.Name = "country_cmbx";
            this.country_cmbx.Size = new System.Drawing.Size(384, 21);
            this.country_cmbx.TabIndex = 23;
            this.country_cmbx.SelectedIndexChanged += new System.EventHandler(this.country_cmbx_SelectedIndexChanged);
            // 
            // information_numeric
            // 
            this.information_numeric.Location = new System.Drawing.Point(153, 249);
            this.information_numeric.Multiline = true;
            this.information_numeric.Name = "information_numeric";
            this.information_numeric.Size = new System.Drawing.Size(384, 148);
            this.information_numeric.TabIndex = 21;
            // 
            // tourname_txbx
            // 
            this.tourname_txbx.Location = new System.Drawing.Point(153, 14);
            this.tourname_txbx.Name = "tourname_txbx";
            this.tourname_txbx.Size = new System.Drawing.Size(384, 20);
            this.tourname_txbx.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Название тура:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Информация:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Мест:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дата выезда:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата заезда:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Отель:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Страна:";
            // 
            // AddEditTourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.seats_numeric);
            this.Controls.Add(this.price_numeric);
            this.Controls.Add(this.dateend_dtpc);
            this.Controls.Add(this.dateBegin_dtpc);
            this.Controls.Add(this.hotel_cmbx);
            this.Controls.Add(this.country_cmbx);
            this.Controls.Add(this.information_numeric);
            this.Controls.Add(this.tourname_txbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditTourForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить\\Изменить тур";
            this.Load += new System.EventHandler(this.AddEditTourForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seats_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.NumericUpDown seats_numeric;
        private System.Windows.Forms.NumericUpDown price_numeric;
        private System.Windows.Forms.DateTimePicker dateend_dtpc;
        private System.Windows.Forms.DateTimePicker dateBegin_dtpc;
        private System.Windows.Forms.ComboBox hotel_cmbx;
        private System.Windows.Forms.ComboBox country_cmbx;
        private System.Windows.Forms.TextBox information_numeric;
        private System.Windows.Forms.TextBox tourname_txbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}