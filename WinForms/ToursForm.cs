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
    public partial class ToursForm : Form
    {
        public ToursForm()
        {
            InitializeComponent();
        }

        private void ToursForm_Load(object sender, EventArgs e)
        {
            List<Tour> rr =	DataAccess.GetTours();
            tours_dgv.DataSource = rr;
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
			this.dateOfcommencement_dtpc.Value = DateTime.Now.Date.AddDays(-1.0);
		}

        private void tours_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            bool flag = this.tours_dgv.Columns["_Country"] != null;
            if (flag)
            {
                this.tours_dgv.Columns["_Country"].HeaderText = "Старана";
            }
            bool flag2 = this.tours_dgv.Columns["_Hotel"] != null;
            if (flag2)
            {
                this.tours_dgv.Columns["_Hotel"].HeaderText = "Отель";
            }
            bool flag3 = this.tours_dgv.Columns["DateBegin"] != null;
            if (flag3)
            {
                this.tours_dgv.Columns["DateBegin"].HeaderText = "Дата начала";
            }
            bool flag4 = this.tours_dgv.Columns["DateEnd"] != null;
            if (flag4)
            {
                this.tours_dgv.Columns["DateEnd"].HeaderText = "Дата окончания";
            }
            bool flag5 = this.tours_dgv.Columns["TourName"] != null;
            if (flag5)
            {
                this.tours_dgv.Columns["TourName"].HeaderText = "Название тура";
            }
             
            if (this.tours_dgv.Columns["Information"] != null)
            {
                this.tours_dgv.Columns["Information"].HeaderText = "Информация";
            }

            if (this.tours_dgv.Columns["Seats"] != null)
            {
                this.tours_dgv.Columns["Seats"].HeaderText = "Мест";
            }
            if (this.tours_dgv.Columns["Price"] != null)
            {
                this.tours_dgv.Columns["Price"].HeaderText = "Цена";
            }
            this.tours_dgv.Columns["Tour_id"].Visible = false;

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
			this.tours_dgv.DataSource = DataAccess.GetTours(this.name_txbx.Text, this.country_cmbx.SelectedItem as Country, this.price_numeric.Value, this.dateOfcommencement_dtpc.Value);
		}

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditTourForm addEditTourForm = new AddEditTourForm();
            addEditTourForm.ShowDialog();
            this.tours_dgv.DataSource = DataAccess.GetTours();
            tours_dgv.Refresh();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            bool flag = this.tours_dgv.SelectedRows.Count > 0;
            if (flag)
            {
                Tour tour = this.tours_dgv.SelectedRows[0].DataBoundItem as Tour;
                AddEditTourForm addEditTourForm = new AddEditTourForm(tour);
                addEditTourForm.ShowDialog();
               this.tours_dgv.DataSource = DataAccess.GetTours();
                tours_dgv.Refresh();

            }
        }

     

        private void ext_btn_Click(object sender, EventArgs e)
        {
			base.Close();
		}

        private void hotelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);

        }
    }
}
