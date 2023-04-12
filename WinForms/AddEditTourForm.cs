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
    public partial class AddEditTourForm : Form
	{
		public AddEditTourForm()
		{
			this.InitializeComponent();
		}

	
		public AddEditTourForm(Tour tour)
		{
			this.InitializeComponent();
			this.tour = tour;
		}

		private void AddEditTourForm_Load(object sender, EventArgs e)
		{
			List<Country> country = DataAccess.GetCountry();
			this.country_cmbx.DataSource = country;
			this.country_cmbx.SelectedItem = null;
			this.country_cmbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.country_cmbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
			foreach (Country country2 in country)
			{
				autoCompleteStringCollection.Add(country2.ToString());
			}
			this.country_cmbx.AutoCompleteCustomSource = autoCompleteStringCollection;
			bool flag = this.tour != null;
			if (flag)
			{
				this.tourname_txbx.Text = this.tour.TourName;
				this.country_cmbx.SelectedItem = this.tour._Country;
				this.hotel_cmbx.SelectedItem = this.tour._Hotel;
				this.information_numeric.Text = this.tour.Information;
				this.price_numeric.Value = this.tour.Price;
				this.seats_numeric.Value = this.tour.Seats;
				this.dateBegin_dtpc.Value = this.tour.DateBegin;
                DateTime tt =this.tour.DateEnd;
				
				//иначе вызовет ошибку
				this.dateend_dtpc.MinDate= new DateTime(1753, 01, 01, 0, 0, 0);
				this.dateend_dtpc.Value = tt;
			}
		}

	
		private void country_cmbx_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.country_cmbx.SelectedItem != null;
			if (flag)
			{
				this.hotel_cmbx.DataSource = DataAccess.GetHotels(string.Empty, this.country_cmbx.SelectedItem as Country, string.Empty, string.Empty);
			}
		}

	
		private void dateBegin_dtpc_ValueChanged(object sender, EventArgs e)
		{
			this.dateend_dtpc.MinDate = this.dateBegin_dtpc.Value.AddDays(1.0);
		}

	
		private void dateend_dtpc_ValueChanged(object sender, EventArgs e)
		{
			bool flag = this.dateBegin_dtpc.Value > this.dateend_dtpc.Value;
			if (flag)
			{
				this.dateBegin_dtpc.Value = this.dateend_dtpc.Value.AddDays(-1.0);
			}
		}

	
		private void cancel_btn_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		
		private void ok_btn_Click(object sender, EventArgs e)
		{
			bool flag = this.tourname_txbx.Text.Length > 0 && this.country_cmbx.SelectedItem != null && this.hotel_cmbx.SelectedItem != null && this.information_numeric.Text.Length > 0 && this.price_numeric.Value > 0m;
			if (flag)
			{
				bool flag2 = this.tour != null;
				if (flag2)
				{
					this.tour.TourName = this.tourname_txbx.Text;
					this.tour.Information = this.information_numeric.Text;
					this.tour.Price = this.price_numeric.Value;
					this.tour.Seats = (int)this.seats_numeric.Value;
					this.tour._Country = (this.country_cmbx.SelectedItem as Country);
					this.tour._Hotel = (this.hotel_cmbx.SelectedItem as Hotel);
					this.tour.DateBegin = this.dateBegin_dtpc.Value.Date;
					this.tour.DateEnd = this.dateend_dtpc.Value.Date;
					DataAccess.UpdateTour(this.tour);
					base.Close();
				}
				else
				{
					DataAccess.AddTour(new Tour
					{
						TourName = this.tourname_txbx.Text,
						Information = this.information_numeric.Text,
						Price = this.price_numeric.Value,
						Seats = (int)this.seats_numeric.Value,
						_Country = (this.country_cmbx.SelectedItem as Country),
						_Hotel = (this.hotel_cmbx.SelectedItem as Hotel),
						DateBegin = this.dateBegin_dtpc.Value.Date,
						DateEnd = this.dateend_dtpc.Value.Date
					});
					base.Close();
				}
			}
			else
			{
				MessageBox.Show("Заполните все необходимые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}


		private Tour tour;
	}
}
