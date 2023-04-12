using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TouristCompany.Entities;
using TouristCompany.WinForms;


namespace TouristCompany
{
    public partial class MainForm : Form
    {
        private Employee currentEmpl;
        public MainForm(Employee emp)
        {
            InitializeComponent();
            currentEmpl = emp;
           

            DataAccess.CurrentEmployee = this.currentEmpl;
            this.user_status_lbl.Text = this.currentEmpl.ToString();
            var rr = DataAccess.GetTravels();
            this.InfoGrid.DataSource = rr;

        }

        private void InfoGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            bool flag = this.InfoGrid.Columns["Tourist_"] != null;
            if (flag)
            {
                this.InfoGrid.Columns["Tourist_"].HeaderText = "Турист";
                InfoGrid.Columns["Tourist_"].DisplayIndex = 5;
            }
            bool flag2 = this.InfoGrid.Columns["Employee_"] != null;
            if (flag2)
            {
                this.InfoGrid.Columns["Employee_"].HeaderText = "Сотрудник";
                InfoGrid.Columns["Employee_"].DisplayIndex = 4;
            }
            bool flag3 = this.InfoGrid.Columns["DateOFIssue"] != null;
            if (flag3)
            {
                this.InfoGrid.Columns["DateOFIssue"].HeaderText = "Дата выдачи";
                InfoGrid.Columns["DateOFIssue"].DisplayIndex = 3;
            }
            bool flag4 = this.InfoGrid.Columns["CostTour"] != null;
            if (flag4)
            {
                this.InfoGrid.Columns["CostTour"].HeaderText = "Стоимость тура";
                InfoGrid.Columns["CostTour"].DisplayIndex = 2;
            }
            bool flag5 = this.InfoGrid.Columns["DiscountedPrice"] != null;
            if (flag5)
            {
                this.InfoGrid.Columns["DiscountedPrice"].HeaderText = "Цена со скидкой";
                InfoGrid.Columns["DiscountedPrice"].DisplayIndex = 3;
            }
            if (this.InfoGrid.Columns["Fare"] != null)
            {
                this.InfoGrid.Columns["Fare"].HeaderText = "Стоимость проезда";
                InfoGrid.Columns["Fare"].DisplayIndex = 1;
            }
            if (this.InfoGrid.Columns["Tour"] != null)
            {
                this.InfoGrid.Columns["Tour"].HeaderText = "Тур";
                InfoGrid.Columns["Tour"].DisplayIndex = 0;
            }
            if (this.InfoGrid.Columns["id_travel"] != null)
            {
                InfoGrid.Columns["id_travel"].Visible = false;
            }

            if (this.InfoGrid.Columns["Tour_ID"] != null)
            {
                InfoGrid.Columns["Tour_ID"].Visible = false;
            }
            if (this.InfoGrid.Columns["Agent_id"] != null)
            {
                InfoGrid.Columns["Agent_id"].Visible = false;
            }
            if (this.InfoGrid.Columns["Tourist_id"] != null)
            {
                InfoGrid.Columns["Tourist_id"].Visible = false;
            }
        }

        private void InfoGrid_SelectionChanged(object sender, EventArgs e)
        {
            bool flag = this.InfoGrid.SelectedRows.Count > 0;
            if (flag)
            {
                Travel travel = this.InfoGrid.SelectedRows[0].DataBoundItem as Travel;
                this.country_txbx.Text = travel.Tour._Country.ToString();
                this.hotel_txbx.Text = travel.Tour._Hotel.ToString();
                this.info_travel_txbx.Text = travel.Tour.Information;
                this.info_txbx.Text = travel.Tour._Hotel.Information;
                this.services_txbx.Text = travel.Tour._Hotel.HotelServices;
                this.datebegin_dtpc.Value = travel.Tour.DateBegin;
                this.dateend_dtpc.Value = travel.Tour.DateEnd;
            }
            else
            {
                this.country_txbx.Text = string.Empty;
                this.hotel_txbx.Text = string.Empty;
                this.info_travel_txbx.Text = string.Empty;
                this.info_txbx.Text = string.Empty;
                this.services_txbx.Text = string.Empty;
                this.datebegin_dtpc.Value = DateTime.Now;
                this.dateend_dtpc.Value = DateTime.Now;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void HotelDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotelsForm hotelsForm = new HotelsForm();
            hotelsForm.ShowDialog();
        }

        private void ServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm();
            serviceForm.ShowDialog();
        }

        private void TouristsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TouristForm touristForm = new TouristForm();
            touristForm.ShowDialog();
        }

        private void ToursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToursForm toursForm = new ToursForm();
            toursForm.ShowDialog();
        }

        private void AddOrder_btn_Click(object sender, EventArgs e)
        {
            AddEditTravelForm addEditTravelForm = new AddEditTravelForm();
            addEditTravelForm.ShowDialog();
            this.InfoGrid.DataSource = DataAccess.GetTravels();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            bool flag = this.InfoGrid.SelectedRows.Count > 0;
            if (flag)
            {
                Travel travel = this.InfoGrid.SelectedRows[0].DataBoundItem as Travel;
                AddEditTravelForm addEditTravelForm = new AddEditTravelForm(travel);
                addEditTravelForm.ShowDialog();
                this.InfoGrid.DataSource = DataAccess.GetTravels();
            }
        }

        private void Ext_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
