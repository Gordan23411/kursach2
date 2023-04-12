
namespace TouristCompany
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InfoGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ext_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.addOrder_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.info_txbx = new System.Windows.Forms.TextBox();
            this.services_txbx = new System.Windows.Forms.TextBox();
            this.hotel_txbx = new System.Windows.Forms.TextBox();
            this.country_txbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateend_dtpc = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.datebegin_dtpc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.user_status_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.touristsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.info_travel_txbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InfoGrid);
            this.groupBox1.Location = new System.Drawing.Point(26, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 340);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отчет по турам";
            // 
            // InfoGrid
            // 
            this.InfoGrid.AllowUserToAddRows = false;
            this.InfoGrid.AllowUserToDeleteRows = false;
            this.InfoGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.InfoGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.InfoGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InfoGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.InfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.InfoGrid.Location = new System.Drawing.Point(0, 31);
            this.InfoGrid.Name = "InfoGrid";
            this.InfoGrid.ReadOnly = true;
            this.InfoGrid.RowHeadersVisible = false;
            this.InfoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InfoGrid.Size = new System.Drawing.Size(973, 303);
            this.InfoGrid.TabIndex = 0;
            this.InfoGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.InfoGrid_DataBindingComplete);
            this.InfoGrid.SelectionChanged += new System.EventHandler(this.InfoGrid_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ext_btn
            // 
            this.ext_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ext_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ext_btn.Location = new System.Drawing.Point(873, 553);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(103, 34);
            this.ext_btn.TabIndex = 14;
            this.ext_btn.Text = "Выход";
            this.ext_btn.UseVisualStyleBackColor = true;
            this.ext_btn.Click += new System.EventHandler(this.Ext_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_btn.Location = new System.Drawing.Point(226, 553);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(103, 34);
            this.edit_btn.TabIndex = 15;
            this.edit_btn.Text = "Изменить";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // addOrder_btn
            // 
            this.addOrder_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addOrder_btn.Location = new System.Drawing.Point(12, 552);
            this.addOrder_btn.Name = "addOrder_btn";
            this.addOrder_btn.Size = new System.Drawing.Size(208, 35);
            this.addOrder_btn.TabIndex = 13;
            this.addOrder_btn.Text = "Отправить запрос на путешествие";
            this.addOrder_btn.UseVisualStyleBackColor = true;
            this.addOrder_btn.Click += new System.EventHandler(this.AddOrder_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.info_txbx);
            this.groupBox2.Controls.Add(this.services_txbx);
            this.groupBox2.Controls.Add(this.info_travel_txbx);
            this.groupBox2.Controls.Add(this.hotel_txbx);
            this.groupBox2.Controls.Add(this.country_txbx);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateend_dtpc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.datebegin_dtpc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 439);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(983, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о путешествии";
            // 
            // info_txbx
            // 
            this.info_txbx.Location = new System.Drawing.Point(374, 70);
            this.info_txbx.Name = "info_txbx";
            this.info_txbx.ReadOnly = true;
            this.info_txbx.Size = new System.Drawing.Size(291, 20);
            this.info_txbx.TabIndex = 2;
            // 
            // services_txbx
            // 
            this.services_txbx.Location = new System.Drawing.Point(374, 45);
            this.services_txbx.Name = "services_txbx";
            this.services_txbx.ReadOnly = true;
            this.services_txbx.Size = new System.Drawing.Size(291, 20);
            this.services_txbx.TabIndex = 2;
            // 
            // hotel_txbx
            // 
            this.hotel_txbx.Location = new System.Drawing.Point(374, 20);
            this.hotel_txbx.Name = "hotel_txbx";
            this.hotel_txbx.ReadOnly = true;
            this.hotel_txbx.Size = new System.Drawing.Size(291, 20);
            this.hotel_txbx.TabIndex = 2;
            // 
            // country_txbx
            // 
            this.country_txbx.Location = new System.Drawing.Point(112, 20);
            this.country_txbx.Name = "country_txbx";
            this.country_txbx.ReadOnly = true;
            this.country_txbx.Size = new System.Drawing.Size(183, 20);
            this.country_txbx.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Информация";
            // 
            // dateend_dtpc
            // 
            this.dateend_dtpc.Enabled = false;
            this.dateend_dtpc.Location = new System.Drawing.Point(112, 67);
            this.dateend_dtpc.Name = "dateend_dtpc";
            this.dateend_dtpc.Size = new System.Drawing.Size(183, 20);
            this.dateend_dtpc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Сервис";
            // 
            // datebegin_dtpc
            // 
            this.datebegin_dtpc.Enabled = false;
            this.datebegin_dtpc.Location = new System.Drawing.Point(112, 43);
            this.datebegin_dtpc.Name = "datebegin_dtpc";
            this.datebegin_dtpc.Size = new System.Drawing.Size(183, 20);
            this.datebegin_dtpc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Отель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата выезда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Страна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заезда";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.user_status_lbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 609);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1042, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(137, 17);
            this.toolStripStatusLabel1.Text = "Текущий пользователь:";
            // 
            // user_status_lbl
            // 
            this.user_status_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_status_lbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.user_status_lbl.Name = "user_status_lbl";
            this.user_status_lbl.Size = new System.Drawing.Size(23, 17);
            this.user_status_lbl.Text = "<>";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.directoriesToolStripMenuItem,
            this.toursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.programToolStripMenuItem.Text = "Программа";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // directoriesToolStripMenuItem
            // 
            this.directoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelDirectoryToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.touristsToolStripMenuItem});
            this.directoriesToolStripMenuItem.Name = "directoriesToolStripMenuItem";
            this.directoriesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.directoriesToolStripMenuItem.Text = "Каталог";
            // 
            // hotelDirectoryToolStripMenuItem
            // 
            this.hotelDirectoryToolStripMenuItem.Name = "hotelDirectoryToolStripMenuItem";
            this.hotelDirectoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hotelDirectoryToolStripMenuItem.Text = "Список отелей";
            this.hotelDirectoryToolStripMenuItem.Click += new System.EventHandler(this.HotelDirectoryToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.servicesToolStripMenuItem.Text = "Услуги";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.ServicesToolStripMenuItem_Click);
            // 
            // touristsToolStripMenuItem
            // 
            this.touristsToolStripMenuItem.Name = "touristsToolStripMenuItem";
            this.touristsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.touristsToolStripMenuItem.Text = "Туристы";
            this.touristsToolStripMenuItem.Click += new System.EventHandler(this.TouristsToolStripMenuItem_Click);
            // 
            // toursToolStripMenuItem
            // 
            this.toursToolStripMenuItem.Name = "toursToolStripMenuItem";
            this.toursToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toursToolStripMenuItem.Text = "Туры";
            this.toursToolStripMenuItem.Click += new System.EventHandler(this.ToursToolStripMenuItem_Click);
            // 
            // info_travel_txbx
            // 
            this.info_travel_txbx.Location = new System.Drawing.Point(758, 19);
            this.info_travel_txbx.Multiline = true;
            this.info_travel_txbx.Name = "info_travel_txbx";
            this.info_travel_txbx.ReadOnly = true;
            this.info_travel_txbx.Size = new System.Drawing.Size(219, 70);
            this.info_travel_txbx.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Подробности \r\nо путешествии";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 631);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ext_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.addOrder_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Туристическая фирма";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView InfoGrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button addOrder_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox info_txbx;
        private System.Windows.Forms.TextBox services_txbx;
        private System.Windows.Forms.TextBox hotel_txbx;
        private System.Windows.Forms.TextBox country_txbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateend_dtpc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datebegin_dtpc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel user_status_lbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem touristsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toursToolStripMenuItem;
        private System.Windows.Forms.TextBox info_travel_txbx;
        private System.Windows.Forms.Label label7;
    }
}

