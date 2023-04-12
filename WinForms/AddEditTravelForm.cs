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
    public partial class AddEditTravelForm : Form
    {
        public AddEditTravelForm()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
			bool flag = this.tourist_cmbx.SelectedItem != null && this.tour_cmbx.SelectedItem != null;
			if (flag)
			{
				bool flag2 = this.travel != null;
				if (flag2)
				{
					this.travel.CostTour = this.cost_num.Value;
					this.travel.DateOfIssue = this.dateTimePicker1.Value.Date;
					this.travel.DiscountedPrice = this.discounted_num.Value;
					this.travel.Fare = this.fare_num.Value;
					this.travel.Employee_ = DataAccess.CurrentEmployee;
					this.travel.Tourist_ = (this.tourist_cmbx.SelectedItem as Tourist);
					this.travel.Tour = (this.tour_cmbx.SelectedItem as Tour);
					DataAccess.UpdateTravel(this.travel);
					base.Close();
				}
				else
				{
					DataAccess.InsertTravel(new Travel
					{
						CostTour = this.cost_num.Value,
						DateOfIssue = this.dateTimePicker1.Value.Date,
						DiscountedPrice = this.discounted_num.Value,
						Fare = this.fare_num.Value,
						Employee_ = DataAccess.CurrentEmployee,
						Tourist_ = (this.tourist_cmbx.SelectedItem as Tourist),
						Tour = (this.tour_cmbx.SelectedItem as Tour)
					});
					base.Close();
				}
			}
			else
			{
				MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

        private void cancel_btn_Click(object sender, EventArgs e)
        {
			base.Close();
		}

		private Travel travel;

        private void tour_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
			bool flag = this.tour_cmbx.SelectedItem != null;
			if (flag)
			{
				Tour tour = this.tour_cmbx.SelectedItem as Tour;
				this.cost_num.Value = tour.Price;
				this.discounted_num.Value = (((tour.DateBegin - DateTime.Now).Days < 3) ? (tour.Price * 0.75m) : (tour.Price * 0.9m));
				this.dateTimePicker1.Value = DateTime.Now.Date;
			}
			else
			{
				this.cost_num.Value = 0m;
				this.discounted_num.Value = 0m;
			}
		}

		public AddEditTravelForm(Travel travel)
		{
			this.travel = travel;
			this.InitializeComponent();
		}

		private void AddEditTravelForm_Load(object sender, EventArgs e)
        {
			List<Tourist> tourists = DataAccess.GetTourists();
			this.tourist_cmbx.DataSource = tourists;
			this.tourist_cmbx.SelectedItem = null;
			this.tourist_cmbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tourist_cmbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
			foreach (Tourist tourist in tourists)
			{
				autoCompleteStringCollection.Add(tourist.ToString());
			}
			this.tourist_cmbx.AutoCompleteCustomSource = autoCompleteStringCollection;
			List<Tour> tours = DataAccess.GetTours(string.Empty, null, 0m, DateTime.Now.Date);
			this.tour_cmbx.DataSource = tours;
			this.tour_cmbx.SelectedItem = null;
			this.tour_cmbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tour_cmbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			AutoCompleteStringCollection autoCompleteStringCollection2 = new AutoCompleteStringCollection();
			foreach (Tour tour in tours)
			{
				autoCompleteStringCollection2.Add(tour.ToString());
			}
			this.tour_cmbx.AutoCompleteCustomSource = autoCompleteStringCollection;
			bool flag = this.travel != null;
			if (flag)
			{
				this.tourist_cmbx.SelectedItem = this.travel.Tourist_;
				this.tour_cmbx.SelectedItem = this.travel.Tour;
				this.cost_num.Value = this.travel.CostTour;
				this.fare_num.Value = this.travel.Fare;
				this.discounted_num.Value = this.travel.DiscountedPrice;
				this.dateTimePicker1.Value = this.travel.DateOfIssue;
			}
		}
    }
}
