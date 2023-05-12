using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouristCompany.Entities;
using TouristCompany.WinForms;

namespace TouristCompany
{
    static class Program
    {

        /// Глав точка входа

        [STAThread]
        static void Main()
        {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			LoginForm loginForm = new LoginForm();
			loginForm.FormClosing += Program.Lf_FormClosing;
			Application.Run(loginForm);
			bool flag = emp != null;
			if (flag)
			{
				new MainForm(emp).ShowDialog();
			}
			else
			{
				Application.Exit();
			}
		}

		private static void Lf_FormClosing(object sender, FormClosingEventArgs e)
		{
			emp = (sender as LoginForm)._Employee;
		}

		private static Employee emp;
	}
}
