
namespace TouristCompany.WinForms
{
    partial class ToursForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateOfcommencement_dtpc = new System.Windows.Forms.DateTimePicker();
            this.price_numeric = new System.Windows.Forms.NumericUpDown();
            this.search_btn = new System.Windows.Forms.Button();
            this.country_cmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_txbx = new System.Windows.Forms.TextBox();
            this.ext_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tours_dgv = new System.Windows.Forms.DataGridView();
            this.dBDataSet = new TouristCompany.DBTourDataSet();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelTableAdapter = new TouristCompany.DBTourDataSetTableAdapters.HotelTableAdapter();
            this.tableAdapterManager = new TouristCompany.DBTourDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.price_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tours_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateOfcommencement_dtpc
            // 
            this.dateOfcommencement_dtpc.Location = new System.Drawing.Point(682, 8);
            this.dateOfcommencement_dtpc.Name = "dateOfcommencement_dtpc";
            this.dateOfcommencement_dtpc.Size = new System.Drawing.Size(149, 20);
            this.dateOfcommencement_dtpc.TabIndex = 34;
            // 
            // price_numeric
            // 
            this.price_numeric.Location = new System.Drawing.Point(537, 8);
            this.price_numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.price_numeric.Name = "price_numeric";
            this.price_numeric.Size = new System.Drawing.Size(138, 20);
            this.price_numeric.TabIndex = 33;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(837, 5);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(135, 23);
            this.search_btn.TabIndex = 32;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // country_cmbx
            // 
            this.country_cmbx.FormattingEnabled = true;
            this.country_cmbx.Location = new System.Drawing.Point(291, 7);
            this.country_cmbx.Name = "country_cmbx";
            this.country_cmbx.Size = new System.Drawing.Size(193, 21);
            this.country_cmbx.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Страна:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Цена:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Тур:";
            // 
            // name_txbx
            // 
            this.name_txbx.Location = new System.Drawing.Point(60, 8);
            this.name_txbx.Name = "name_txbx";
            this.name_txbx.Size = new System.Drawing.Size(173, 20);
            this.name_txbx.TabIndex = 27;
            // 
            // ext_btn
            // 
            this.ext_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ext_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ext_btn.Location = new System.Drawing.Point(877, 499);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(103, 34);
            this.ext_btn.TabIndex = 23;
            this.ext_btn.Text = "Выход";
            this.ext_btn.UseVisualStyleBackColor = true;
            this.ext_btn.Click += new System.EventHandler(this.ext_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_btn.Location = new System.Drawing.Point(128, 499);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(103, 34);
            this.edit_btn.TabIndex = 25;
            this.edit_btn.Text = "Редактировать тур";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(19, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "Добавить тур";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tours_dgv
            // 
            this.tours_dgv.AllowUserToAddRows = false;
            this.tours_dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.tours_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tours_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tours_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tours_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tours_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tours_dgv.Location = new System.Drawing.Point(8, 34);
            this.tours_dgv.Name = "tours_dgv";
            this.tours_dgv.ReadOnly = true;
            this.tours_dgv.RowHeadersVisible = false;
            this.tours_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tours_dgv.Size = new System.Drawing.Size(972, 459);
            this.tours_dgv.TabIndex = 22;
            this.tours_dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tours_dgv_DataBindingComplete);
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.dBDataSet;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HotelServiceTableAdapter = null;
            this.tableAdapterManager.HotelTableAdapter = this.hotelTableAdapter;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.TouristTableAdapter = null;
            this.tableAdapterManager.TourTableAdapter = null;
            this.tableAdapterManager.TravelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TouristCompany.DBTourDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.CountryTableAdapter = null;
            // 
            // ToursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 545);
            this.Controls.Add(this.dateOfcommencement_dtpc);
            this.Controls.Add(this.price_numeric);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.country_cmbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_txbx);
            this.Controls.Add(this.ext_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tours_dgv);
            this.Name = "ToursForm";
            this.Text = "Окно туров";
            this.Load += new System.EventHandler(this.ToursForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.price_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tours_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateOfcommencement_dtpc;
        private System.Windows.Forms.NumericUpDown price_numeric;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.ComboBox country_cmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_txbx;
        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tours_dgv;
        private DBTourDataSet dBDataSet;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private DBTourDataSetTableAdapters.HotelTableAdapter hotelTableAdapter;
        private DBTourDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}