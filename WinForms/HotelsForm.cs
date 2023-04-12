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
    public partial class HotelsForm : Form
    {
        public HotelsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditHotelForm addEditHotelForm = new AddEditHotelForm();
            addEditHotelForm.FormClosing += this._FormClosing;
            addEditHotelForm.ShowDialog();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            bool flag = this.hotels_dgv.SelectedRows.Count > 0;
            if (flag)
            {
                Hotel hotel = this.hotels_dgv.SelectedRows[0].DataBoundItem as Hotel;
                AddEditHotelForm addEditHotelForm = new AddEditHotelForm(hotel);
                addEditHotelForm.FormClosing += this._FormClosing;
                addEditHotelForm.ShowDialog();
            }
        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            this.hotels_dgv.DataSource = DataAccess.GetHotels(this.name_txbx.Text, this.country_cmbx.SelectedItem as Country, this.city_txbx.Text, this.service_txbx.Text);

        }

        private void HotelsForm_Load(object sender, EventArgs e)
        {
       
            this.hotels_dgv.DataSource = DataAccess.GetHotels();
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
        }

        private void _FormClosing(object sender, FormClosingEventArgs e)
        {
            this.hotels_dgv.DataSource = DataAccess.GetHotels(this.name_txbx.Text, this.country_cmbx.SelectedItem as Country, this.city_txbx.Text, this.service_txbx.Text);
        }

        private void hotels_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            bool flag = this.hotels_dgv.Columns["_Country"] != null;
            if (flag)
            {
                this.hotels_dgv.Columns["_Country"].HeaderText = "Страна";
            }
            bool flag2 = this.hotels_dgv.Columns["HotelServices"] != null;
            if (flag2)
            {
                this.hotels_dgv.Columns["HotelServices"].HeaderText = "Услуги";
            }
            bool flag3 = this.hotels_dgv.Columns["Rating"] != null;
            if (flag3)
            {
                this.hotels_dgv.Columns["Rating"].Width = 70;
                this.hotels_dgv.Columns["Rating"].HeaderText = "Райтинг";
            }
            bool flag4 = this.hotels_dgv.Columns["City"] != null;
            if (flag4)
            {
                this.hotels_dgv.Columns["City"].Width = 120;
                this.hotels_dgv.Columns["City"].HeaderText = "Город";
            }

            if (this.hotels_dgv.Columns["Information"] != null)
            {
                this.hotels_dgv.Columns["Information"].HeaderText = "Информация";
            }

            if (this.hotels_dgv.Columns["id_hotel"] != null)
            {
                this.hotels_dgv.Columns["id_hotel"].Visible = false;
            }
        }
    }
}
