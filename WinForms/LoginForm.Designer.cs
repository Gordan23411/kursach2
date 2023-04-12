
namespace TouristCompany.WinForms
{
    partial class LoginForm
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
            this.add_new_llbl = new System.Windows.Forms.LinkLabel();
            this.Ok_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.empl_cmbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // add_new_llbl
            // 
            this.add_new_llbl.AutoSize = true;
            this.add_new_llbl.Location = new System.Drawing.Point(160, 53);
            this.add_new_llbl.Name = "add_new_llbl";
            this.add_new_llbl.Size = new System.Drawing.Size(175, 13);
            this.add_new_llbl.TabIndex = 8;
            this.add_new_llbl.TabStop = true;
            this.add_new_llbl.Text = "Добавить\\Изменить Сотрудника";
            this.add_new_llbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.add_new_llbl_LinkClicked);
            // 
            // Ok_btn
            // 
            this.Ok_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ok_btn.Location = new System.Drawing.Point(136, 90);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(96, 33);
            this.Ok_btn.TabIndex = 6;
            this.Ok_btn.Text = "Ок";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_btn.Location = new System.Drawing.Point(238, 90);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(96, 33);
            this.Exit_btn.TabIndex = 7;
            this.Exit_btn.Text = "Выход";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите ваше имя:";
            // 
            // empl_cmbx
            // 
            this.empl_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empl_cmbx.FormattingEnabled = true;
            this.empl_cmbx.Location = new System.Drawing.Point(12, 29);
            this.empl_cmbx.Name = "empl_cmbx";
            this.empl_cmbx.Size = new System.Drawing.Size(322, 21);
            this.empl_cmbx.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 132);
            this.Controls.Add(this.add_new_llbl);
            this.Controls.Add(this.Ok_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empl_cmbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Text = "Окно входа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel add_new_llbl;
        private System.Windows.Forms.Button Ok_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox empl_cmbx;
    }
}