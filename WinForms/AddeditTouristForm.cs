using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouristCompany.Entities;

namespace TouristCompany.WinForms
{
    public partial class AddeditTouristForm : Form
    {
		public AddeditTouristForm()
		{
			this.InitializeComponent();
		}

		public AddeditTouristForm(Tourist tourist)
		{
			this.InitializeComponent();
			this.currentTourist = tourist;
		}

		private void AddeditTouristForm_Load(object sender, EventArgs e)
		{
			bool flag = this.currentTourist != null;
			if (flag)
			{
				this.fname_txbx.Text = this.currentTourist.FName;
				this.lname_txbx.Text = this.currentTourist.LName;
				this.email_txbx.Text = this.currentTourist.Email;
				this.passp_txbx.Text = this.currentTourist.PassportData;
				this.phone_mtxbx.Text = this.currentTourist.Phone;
			}
		}

		private void Exit_btn_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void Ok_btn_Click(object sender, EventArgs e)
		{
			bool flag = this.currentTourist != null;
			if (flag)
			{
				bool flag2 = this.fname_txbx.Text.Length > 0 && this.lname_txbx.Text.Length > 0 && this.passp_txbx.Text.Length > 0 && this.phone_mtxbx.MaskCompleted && this.email_txbx.Text.Length > 0;
				if (flag2)
				{
					try
					{
						this.currentTourist.Email = this.email_txbx.Text;
						this.currentTourist.FName = this.fname_txbx.Text;
						this.currentTourist.LName = this.lname_txbx.Text;
						this.currentTourist.PassportData = this.passp_txbx.Text;
						this.currentTourist.Phone = this.phone_mtxbx.Text;
						bool flag3 = DataAccess.UpdateTourist(this.currentTourist) > 0;
						if (flag3)
						{
							base.Close();
						}
						else
						{
							MessageBox.Show("Не удалось обновить записи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
					}
                    catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
				else
				{
					MessageBox.Show("Заполните все необходимые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				bool flag4 = this.fname_txbx.Text.Length > 0 && this.lname_txbx.Text.Length > 0 && this.passp_txbx.Text.Length > 0 && this.phone_mtxbx.MaskCompleted && this.email_txbx.Text.Length > 0;
				if (flag4)
				{
					try
					{
						bool flag5 = DataAccess.InsertTourist(this.fname_txbx.Text, this.lname_txbx.Text, this.passp_txbx.Text, this.phone_mtxbx.Text, this.email_txbx.Text) > 0;
						if (flag5)
						{
							base.Close();
						}
						else
						{
							MessageBox.Show("Добавление записи не удалось!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
					}
					catch (Exception ex2)
					{
						MessageBox.Show(ex2.Message);
					}
				}
				else
				{
					MessageBox.Show("Заполните все необходимые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}

		private Tourist currentTourist;
	}
}
