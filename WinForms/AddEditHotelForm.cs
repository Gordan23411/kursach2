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
    public partial class AddEditHotelForm : Form
    {
        public AddEditHotelForm()
        {
            InitializeComponent();
        }
        public AddEditHotelForm(Hotel hotel)
        {
            this.InitializeComponent();
            this.currentHotel = hotel;
        }

		private void AddEditHotelForm_Load(object sender, EventArgs e)
		{
			List<Country> country = DataAccess.GetCountry();
			this.country_cmbx.DataSource = country;
			this.country_cmbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.country_cmbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
			foreach (Country country2 in country)
			{
				autoCompleteStringCollection.Add(country2.ToString());
			}
			this.country_cmbx.AutoCompleteCustomSource = autoCompleteStringCollection;
			this.service_cmbx.DataSource = DataAccess.GetServices();
			this.service_cmbx.SelectedItem = null;
			bool flag = this.currentHotel != null;
			if (flag)
			{
				this.hotelName_txbx.Text = this.currentHotel.Name;
				this.city_txbx.Text = this.currentHotel.City;
				this.info_txbx.Text = this.currentHotel.Information;
				this.country_cmbx.SelectedItem = this.currentHotel._Country;
				this.hotelService = this.currentHotel._hotelServices;
				this.hotelServices_dgv.DataSource = this.hotelService;
				this.rating_numeric.Value = this.currentHotel.Rating;
			}
			else
			{
				this.country_cmbx.SelectedItem = null;
				this.hotelService = new List<Service>();
			}
		}

        private void cancel_btn_Click(object sender, EventArgs e)
        {
			base.Close();
		}

        private void ok_btn_Click(object sender, EventArgs e)
        {
			bool flag = this.currentHotel != null;
			if (flag)
			{
				bool flag2 = this.city_txbx.Text.Length > 0 && this.hotelName_txbx.Text.Length > 0 && this.info_txbx.Text.Length > 0 && this.country_cmbx.SelectedItem != null;
				if (flag2)
				{
					this.currentHotel.City = this.city_txbx.Text;
					this.currentHotel.Name = this.hotelName_txbx.Text;
					this.currentHotel.Information = this.info_txbx.Text;
					this.currentHotel.Rating = Convert.ToInt32(this.rating_numeric.Value);
					this.currentHotel._Country = (this.country_cmbx.SelectedItem as Country);
					this.currentHotel._hotelServices = this.hotelService;
					int num = DataAccess.UpdateHotel(this.currentHotel);
					bool flag3 = num > 0;
					if (flag3)
					{
						DataAccess.UpdateHotelService(this.currentHotel);
						base.Close();
					}
				}
			}
			else
			{
				bool flag4 = this.city_txbx.Text.Length > 0 && this.hotelName_txbx.Text.Length > 0 && this.info_txbx.Text.Length > 0 && this.country_cmbx.SelectedItem != null;
				if (flag4)
				{
					Hotel newHotel = new Hotel
					{
						City = this.city_txbx.Text,
						Name = this.hotelName_txbx.Text,
						Information = this.info_txbx.Text,
						Rating = Convert.ToInt32(this.rating_numeric.Value),
						_Country = (this.country_cmbx.SelectedItem as Country),
						_hotelServices = this.hotelService
					};
					int num2 = DataAccess.InsertHotel(newHotel);
					bool flag5 = num2 > 0;
					if (flag5)
					{
						MessageBox.Show("Добавлено успешно!");
						base.Close();
					}
				}
			}
		}

        private void addServ_btn_Click(object sender, EventArgs e)
        {
			Service service = this.service_cmbx.SelectedItem as Service;
			bool flag = service != null && !this.hotelService.Contains(service);
			if (flag)
			{
				this.hotelService.Add(service);
				this.hotelServices_dgv.DataSource = null;
				this.hotelServices_dgv.DataSource = this.hotelService;
			}
		}

		private Hotel currentHotel;
		private List<Service> hotelService;
	}
}
