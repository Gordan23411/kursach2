
namespace TouristCompany.WinForms
{
    partial class HotelsForm
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
            this.ext_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.country_cmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.city_txbx = new System.Windows.Forms.TextBox();
            this.service_txbx = new System.Windows.Forms.TextBox();
            this.name_txbx = new System.Windows.Forms.TextBox();
            this.hotels_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hotels_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ext_btn
            // 
            this.ext_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ext_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ext_btn.Location = new System.Drawing.Point(893, 688);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(103, 34);
            this.ext_btn.TabIndex = 18;
            this.ext_btn.Text = "Выход";
            this.ext_btn.UseVisualStyleBackColor = true;
            this.ext_btn.Click += new System.EventHandler(this.ext_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_btn.Location = new System.Drawing.Point(121, 689);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(103, 34);
            this.edit_btn.TabIndex = 19;
            this.edit_btn.Text = "Редактировать";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 689);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "Добавить отель";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(832, 36);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(176, 23);
            this.search_btn.TabIndex = 17;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Город:";
            // 
            // country_cmbx
            // 
            this.country_cmbx.FormattingEnabled = true;
            this.country_cmbx.Location = new System.Drawing.Point(287, 38);
            this.country_cmbx.Name = "country_cmbx";
            this.country_cmbx.Size = new System.Drawing.Size(193, 21);
            this.country_cmbx.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Страна:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Назвение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Услуги:";
            // 
            // city_txbx
            // 
            this.city_txbx.Location = new System.Drawing.Point(522, 38);
            this.city_txbx.Name = "city_txbx";
            this.city_txbx.Size = new System.Drawing.Size(99, 20);
            this.city_txbx.TabIndex = 9;
            // 
            // service_txbx
            // 
            this.service_txbx.Location = new System.Drawing.Point(687, 38);
            this.service_txbx.Name = "service_txbx";
            this.service_txbx.Size = new System.Drawing.Size(127, 20);
            this.service_txbx.TabIndex = 10;
            // 
            // name_txbx
            // 
            this.name_txbx.Location = new System.Drawing.Point(60, 38);
            this.name_txbx.Name = "name_txbx";
            this.name_txbx.Size = new System.Drawing.Size(173, 20);
            this.name_txbx.TabIndex = 11;
            // 
            // hotels_dgv
            // 
            this.hotels_dgv.AllowUserToAddRows = false;
            this.hotels_dgv.AllowUserToDeleteRows = false;
            this.hotels_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.hotels_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.hotels_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hotels_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hotels_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hotels_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotels_dgv.Location = new System.Drawing.Point(0, 64);
            this.hotels_dgv.Name = "hotels_dgv";
            this.hotels_dgv.ReadOnly = true;
            this.hotels_dgv.RowHeadersVisible = false;
            this.hotels_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hotels_dgv.Size = new System.Drawing.Size(1008, 618);
            this.hotels_dgv.TabIndex = 8;
            this.hotels_dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.hotels_dgv_DataBindingComplete);
            // 
            // HotelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.ext_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.country_cmbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.city_txbx);
            this.Controls.Add(this.service_txbx);
            this.Controls.Add(this.name_txbx);
            this.Controls.Add(this.hotels_dgv);
            this.Name = "HotelsForm";
            this.Text = "Окно отелей";
            this.Load += new System.EventHandler(this.HotelsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotels_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox country_cmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox city_txbx;
        private System.Windows.Forms.TextBox service_txbx;
        private System.Windows.Forms.TextBox name_txbx;
        private System.Windows.Forms.DataGridView hotels_dgv;
    }
}