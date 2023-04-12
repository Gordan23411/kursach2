using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristCompany.WinForms
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

       
        private void exit_btn_Click(object sender, EventArgs e)
        {
			base.Close();
		}

        private void agentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.agentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dBDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заполните все не обходимые поля и повторите попытку");
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Agent". При необходимости она может быть перемещена или удалена.
            this.agentTableAdapter.Fill(this.dBDataSet.Agent);

        }
    }
}
