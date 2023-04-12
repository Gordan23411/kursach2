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
    public partial class TouristForm : Form
    {
		public TouristForm()
		{
			this.InitializeComponent();
		}

	
		private void TouristForm_Load(object sender, EventArgs e)
		{
			this.tourists_dgv.DataSource = DataAccess.GetTourists();
		}

	
		private void tourists_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			bool flag = this.tourists_dgv.Columns["PassportData"] != null;
			if (flag)
			{
				this.tourists_dgv.Columns["PassportData"].HeaderText = "Passport";
			}
			bool flag2 = this.tourists_dgv.Columns["Fname"] != null;
			if (flag2)
			{
				this.tourists_dgv.Columns["Fname"].HeaderText = "First name";
			}
			bool flag3 = this.tourists_dgv.Columns["Lname"] != null;
			if (flag3)
			{
				this.tourists_dgv.Columns["Lname"].HeaderText = "Last name";
			}
		}


		private void edit_btn_Click(object sender, EventArgs e)
		{
			bool flag = this.tourists_dgv.SelectedRows.Count > 0;
			if (flag)
			{
				Tourist tourist = this.tourists_dgv.SelectedRows[0].DataBoundItem as Tourist;
				AddeditTouristForm addeditTouristForm = new AddeditTouristForm(tourist);
				addeditTouristForm.ShowDialog();
				bool maskCompleted = this.phone_mstxbx.MaskCompleted;
				if (maskCompleted)
				{
					this.tourists_dgv.DataSource = DataAccess.GetTourists(this.name_txbx.Text, this.Email_txbx.Text, this.phone_mstxbx.Text);
				}
				else
				{
					this.tourists_dgv.DataSource = DataAccess.GetTourists(this.name_txbx.Text, this.Email_txbx.Text, string.Empty);
				}
			}
		}


		private void new_btn_Click(object sender, EventArgs e)
		{
			AddeditTouristForm addeditTouristForm = new AddeditTouristForm();
			addeditTouristForm.ShowDialog();
			bool maskCompleted = this.phone_mstxbx.MaskCompleted;
			if (maskCompleted)
			{
				this.tourists_dgv.DataSource = DataAccess.GetTourists(this.name_txbx.Text, this.Email_txbx.Text, this.phone_mstxbx.Text);
			}
			else
			{
				this.tourists_dgv.DataSource = DataAccess.GetTourists(this.name_txbx.Text, this.Email_txbx.Text, string.Empty);
			}
		}

	
		private void search_btn_Click(object sender, EventArgs e)
		{
			bool maskCompleted = this.phone_mstxbx.MaskCompleted;
			if (maskCompleted)
			{
				this.tourists_dgv.DataSource = DataAccess.GetTourists(this.name_txbx.Text, this.Email_txbx.Text, this.phone_mstxbx.Text);
			}
			else
			{
				this.tourists_dgv.DataSource = DataAccess.GetTourists(this.name_txbx.Text, this.Email_txbx.Text, string.Empty);
			}
		}

	
		private void ext_btn_Click(object sender, EventArgs e)
		{
			base.Close();
		}

	
		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}
	}
}
