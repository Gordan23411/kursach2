
namespace TouristCompany.WinForms
{
    partial class TouristForm
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
            this.ext_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.phone_mstxbx = new System.Windows.Forms.MaskedTextBox();
            this.Email_txbx = new System.Windows.Forms.TextBox();
            this.name_txbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tourists_dgv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tourists_dgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ext_btn
            // 
            this.ext_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ext_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ext_btn.Location = new System.Drawing.Point(889, 687);
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
            this.edit_btn.Location = new System.Drawing.Point(117, 688);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(103, 34);
            this.edit_btn.TabIndex = 19;
            this.edit_btn.Text = "Редактировать";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // new_btn
            // 
            this.new_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.new_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_btn.Location = new System.Drawing.Point(8, 688);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(103, 34);
            this.new_btn.TabIndex = 20;
            this.new_btn.Text = "Добавить туриста";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(795, 8);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(213, 23);
            this.search_btn.TabIndex = 17;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // phone_mstxbx
            // 
            this.phone_mstxbx.Location = new System.Drawing.Point(342, 10);
            this.phone_mstxbx.Mask = "+7(999) 000-00-00";
            this.phone_mstxbx.Name = "phone_mstxbx";
            this.phone_mstxbx.Size = new System.Drawing.Size(175, 20);
            this.phone_mstxbx.TabIndex = 16;
            // 
            // Email_txbx
            // 
            this.Email_txbx.Location = new System.Drawing.Point(560, 10);
            this.Email_txbx.Name = "Email_txbx";
            this.Email_txbx.Size = new System.Drawing.Size(219, 20);
            this.Email_txbx.TabIndex = 14;
            // 
            // name_txbx
            // 
            this.name_txbx.Location = new System.Drawing.Point(70, 10);
            this.name_txbx.Name = "name_txbx";
            this.name_txbx.Size = new System.Drawing.Size(205, 20);
            this.name_txbx.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Телефон:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название:";
            // 
            // tourists_dgv
            // 
            this.tourists_dgv.AllowUserToAddRows = false;
            this.tourists_dgv.AllowUserToDeleteRows = false;
            this.tourists_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.tourists_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tourists_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tourists_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tourists_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tourists_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tourists_dgv.Location = new System.Drawing.Point(0, 34);
            this.tourists_dgv.Name = "tourists_dgv";
            this.tourists_dgv.ReadOnly = true;
            this.tourists_dgv.RowHeadersVisible = false;
            this.tourists_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tourists_dgv.Size = new System.Drawing.Size(1008, 619);
            this.tourists_dgv.TabIndex = 10;
            this.tourists_dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tourists_dgv_DataBindingComplete);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 70);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // TouristForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.ext_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.phone_mstxbx);
            this.Controls.Add(this.Email_txbx);
            this.Controls.Add(this.name_txbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tourists_dgv);
            this.Name = "TouristForm";
            this.Text = "Окно Туриста";
            this.Load += new System.EventHandler(this.TouristForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tourists_dgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.MaskedTextBox phone_mstxbx;
        private System.Windows.Forms.TextBox Email_txbx;
        private System.Windows.Forms.TextBox name_txbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tourists_dgv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}