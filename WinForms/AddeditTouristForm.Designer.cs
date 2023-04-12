
namespace TouristCompany.WinForms
{
    partial class AddeditTouristForm
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
            this.Ok_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.phone_mtxbx = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.email_txbx = new System.Windows.Forms.TextBox();
            this.passp_txbx = new System.Windows.Forms.TextBox();
            this.lname_txbx = new System.Windows.Forms.TextBox();
            this.fname_txbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ok_btn
            // 
            this.Ok_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ok_btn.Location = new System.Drawing.Point(212, 151);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(80, 34);
            this.Ok_btn.TabIndex = 29;
            this.Ok_btn.Text = "OK";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_btn.Location = new System.Drawing.Point(298, 151);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(80, 34);
            this.exit_btn.TabIndex = 30;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email:";
            // 
            // phone_mtxbx
            // 
            this.phone_mtxbx.Location = new System.Drawing.Point(97, 87);
            this.phone_mtxbx.Mask = "+7(999) 000-00-00";
            this.phone_mtxbx.Name = "phone_mtxbx";
            this.phone_mtxbx.Size = new System.Drawing.Size(276, 20);
            this.phone_mtxbx.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Телефон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Паспорт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Имя:";
            // 
            // email_txbx
            // 
            this.email_txbx.Location = new System.Drawing.Point(97, 113);
            this.email_txbx.Name = "email_txbx";
            this.email_txbx.Size = new System.Drawing.Size(276, 20);
            this.email_txbx.TabIndex = 28;
            // 
            // passp_txbx
            // 
            this.passp_txbx.Location = new System.Drawing.Point(97, 61);
            this.passp_txbx.Name = "passp_txbx";
            this.passp_txbx.Size = new System.Drawing.Size(276, 20);
            this.passp_txbx.TabIndex = 26;
            // 
            // lname_txbx
            // 
            this.lname_txbx.Location = new System.Drawing.Point(97, 35);
            this.lname_txbx.Name = "lname_txbx";
            this.lname_txbx.Size = new System.Drawing.Size(276, 20);
            this.lname_txbx.TabIndex = 25;
            // 
            // fname_txbx
            // 
            this.fname_txbx.Location = new System.Drawing.Point(97, 9);
            this.fname_txbx.Name = "fname_txbx";
            this.fname_txbx.Size = new System.Drawing.Size(276, 20);
            this.fname_txbx.TabIndex = 19;
            // 
            // AddeditTouristForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 194);
            this.Controls.Add(this.Ok_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phone_mtxbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_txbx);
            this.Controls.Add(this.passp_txbx);
            this.Controls.Add(this.lname_txbx);
            this.Controls.Add(this.fname_txbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddeditTouristForm";
            this.Text = "Информация о туристе";
            this.Load += new System.EventHandler(this.AddeditTouristForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox phone_mtxbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email_txbx;
        private System.Windows.Forms.TextBox passp_txbx;
        private System.Windows.Forms.TextBox lname_txbx;
        private System.Windows.Forms.TextBox fname_txbx;
    }
}