using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TouristCompany.DBTourDataSetTableAdapters;
using TouristCompany.Entities;

namespace TouristCompany.WinForms
{
    public partial class LoginForm : Form
    {
        public Employee _Employee;

    
        public LoginForm()
        {
            InitializeComponent();
            empl_cmbx.DataSource = GetEmployees(); //связь сотрудников с окном для выбора сот
        }



        public static List<Employee> GetEmployees() //возвращ к окну выб сот
        {
            AgentTableAdapter employeeTable = new AgentTableAdapter();

            return (from x in employeeTable.GetDataBy()
            select new Employee
                    {
                        ID_Employee = x.Id_agent,
                        Phone = x.Phone,
                        Email = x.Email,
                        FName = x.FName,
                        LName = x.LName,
                        PassportData = x.PassportData
                    }).ToList<Employee>();
        }

        private void add_new_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
            empl_cmbx.DataSource = GetEmployees();
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            this._Employee = (this.empl_cmbx.SelectedItem as Employee);
            base.Close();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}
