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
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
        }

		private void Close_btn_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		
		private void ServiceForm_Load(object sender, EventArgs e)
		{
			this.services_dgv.DataSource = DataAccess.GetServices();

			bool flag = this.services_dgv.Columns["id_service"] != null;
			if (flag)
			{
				this.services_dgv.Columns["id_service"].Visible = false;
			}
		}

		private void EnableControls()
		{
			this.cancel_btn.Enabled = (this.textBox1.Enabled = (this.save_btn.Enabled = true));
		}

		
		private void DisableControls()
		{
			this.cancel_btn.Enabled = (this.textBox1.Enabled = (this.save_btn.Enabled = false));
		}

		private void services_dgv_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.services_dgv.SelectedRows.Count > 0;
			if (flag)
			{
				Service service = this.services_dgv.SelectedRows[0].DataBoundItem as Service;
				this.textBox1.Text = service.Title;
				this.DisableControls();
				this.new_btn.Enabled = (this.edit_btn.Enabled = true);
			}
		}

		
		private void cancel_btn_Click(object sender, EventArgs e)
		{
			bool flag = this.services_dgv.Rows[0] != null;
			if (flag)
			{
				this.services_dgv.Rows[0].Selected = false;
				this.services_dgv.Rows[0].Selected = true;
			}
		}

	
		private void new_btn_Click(object sender, EventArgs e)
		{
			this.new_btn.Enabled = (this.edit_btn.Enabled = (this.isEdit = false));
			this.EnableControls();
			this.textBox1.Text = string.Empty;
		}

	
		private void edit_btn_Click(object sender, EventArgs e)
		{
			this.new_btn.Enabled = (this.edit_btn.Enabled = false);
			this.isEdit = true;
			this.EnableControls();
		}

		
		private void save_btn_Click(object sender, EventArgs e)
		{
			bool flag = this.isEdit;
			if (flag)
			{
				bool flag2 = this.services_dgv.SelectedRows.Count > 0;
				if (flag2)
				{
					Service service = this.services_dgv.SelectedRows[0].DataBoundItem as Service;
					service.Title = this.textBox1.Text;
					DataAccess.UpdateService(service);
					this.services_dgv.DataSource = DataAccess.GetServices();
				}
			}
			else
			{
				bool flag3 = this.textBox1.Text.Trim().Length > 0;
				if (flag3)
				{
					Service service2 = new Service
					{
						Title = this.textBox1.Text
					};
					DataAccess.InsertService(service2);
					this.services_dgv.DataSource = DataAccess.GetServices();
				}
			}
		}

	
		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.services_dgv.SelectedRows.Count > 0;
			if (flag)
			{
				Service service = this.services_dgv.SelectedRows[0].DataBoundItem as Service;
				DataAccess.DeleteServcie(service);
				this.services_dgv.DataSource = DataAccess.GetServices();
			}
		}

	
		private bool isEdit;
	}
}
