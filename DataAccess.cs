using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristCompany.DBTourDataSetTableAdapters;
using TouristCompany.Entities;

namespace TouristCompany
{
	internal class DataAccess
	{
		public static Employee CurrentEmployee { get; set; }

		//начало чтен базы дан
		static DataAccess()
		{
            employeeAdap = new AgentTableAdapter();
			hotelAdap = new HotelTableAdapter();
			countryAdapt = new CountryTableAdapter();
			hsAdap = new HotelServiceTableAdapter();
			serviceAdap = new ServiceTableAdapter();
			touristAdap = new TouristTableAdapter();
			tourAdap = new TourTableAdapter();
            travelAdap = new TravelTableAdapter();
			employeeAdap.Fill(employeeTable);
			hotelAdap.Fill(hotelTable);
			countryAdapt.Fill(countryTable);
			hsAdap.Fill(hsTable);
			serviceAdap.Fill(serviceTable);
			touristAdap.Fill(touristTable);
			tourAdap.Fill(tourTable);
			travelAdap.Fill(travelTable);
		}

        // обнов спис туристов
        public static int UpdateTourist(Tourist currentTourist)
        {
            int result = touristAdap.UpdateQuery(currentTourist.FName, currentTourist.LName, currentTourist.PassportData, currentTourist.Phone, currentTourist.Email, currentTourist.ID_Tourist);
            touristAdap.Fill(touristTable);
            return result;
        }

		// тут обновляется сервис (WI-FI и другая чепуха)
		public static void UpdateService(Service service)
        {
            serviceAdap.UpdateQuery(service.Title, service.id_service);
            serviceAdap.Fill(serviceTable);
        }

		// добав туристов
		public static int InsertTourist(string fname, string lname, string passport, string phone, string email)
		{
			int result = touristAdap.Insert(fname, lname, passport, phone, email);
			touristAdap.Fill(touristTable);
			return result;
		}

		// добав серовиса
		public static void InsertService(Service service)
		{
			serviceAdap.Insert(service.Title);
			serviceAdap.Fill(DataAccess.serviceTable);
		}

		// обнов путиш
		public static void UpdateTravel(Travel travel)
        {
            travelAdap.UpdateQuery(travel.Tour.tour_id, travel.Fare, travel.CostTour, travel.DiscountedPrice, travel.DateOfIssue, DataAccess.CurrentEmployee.ID_Employee, travel.Tourist_.ID_Tourist, travel.id_travel);
            travelAdap.Fill(travelTable);
        }

        // del путиш
        public static void DeleteTravel(Travel travel)
        {
            travelAdap.DeleteQuery(travel.id_travel);
        }

        // del тур
        public static void DeleteTour(Tour tour)
        {
            tourAdap.DeleteQuery(tour.tour_id);
            tourAdap.Fill(tourTable);
        }

        // вывод спис турист
        public static List<Tourist> GetTourists(string name, string email, string phone)
		{
			
			IEnumerable<Tourist> source = GetTourists();
			bool flag = name.Length > 0;
			if (flag)
			{
				source = from x in source
						 where (x.FName + " " + x.LName).ToLower().Contains(name.Trim().ToLower())
						 select x;
			}
			bool flag2 = email.Length > 0;
			if (flag2)
			{
				source = from x in source
						 where x.Email.ToLower().Contains(email.Trim().ToLower())
						 select x;
			}
			bool flag3 = phone.Length > 0;
			if (flag3)
			{
				return source.Select(x => x).Where(x => x.Phone.Contains(phone.Trim().ToLower())).ToList();
			}
			return source.ToList<Tourist>();
		}

		//add страна
		public static void InsertCountry(string nameCountry)
		{
			countryAdapt.Insert(nameCountry);
			countryAdapt.Fill(countryTable);
		}

		//add путиш
		public static void InsertTravel(Travel travel)
        {
            travelAdap.Insert(travel.Tour.tour_id, travel.Fare, travel.CostTour, travel.DiscountedPrice, travel.DateOfIssue, DataAccess.CurrentEmployee.ID_Employee, travel.Tourist_.ID_Tourist);
            travelAdap.Fill(travelTable);
        }

        //add тур
        public static void AddTour(Tour tour)
        {
            tourAdap.Insert(tour.TourName, tour._Country.country_id, tour.Information, tour._Hotel.id_hotel, tour.DateBegin, tour.DateEnd, tour.Price, tour.Seats);
            tourAdap.Fill(tourTable);
        }

        //обнов тура
        public static void UpdateTour(Tour tour)
        {
            tourAdap.UpdateQuery(tour.TourName, tour._Country.country_id, tour.Information, tour._Hotel.id_hotel, tour.DateBegin, tour.DateEnd, tour.Price, tour.Seats, tour.tour_id);
            tourAdap.Fill(tourTable);
        }

        // del сервис
        public static void DeleteServcie(Service service)
        {
            serviceAdap.DeleteQuery(service.id_service);
            serviceAdap.Fill(serviceTable);
            hsAdap.Fill(hsTable);
        }

        //del туриста
        public static void DeleteTourist(Tourist tourist)
        {
            touristAdap.DeleteQuery(tourist.ID_Tourist);
            touristAdap.Fill(touristTable);
        }

        //выводит спис сотруд
        public static List<Employee> GetEmployees()
		{
			var rr = (from x in employeeTable
					  select new Employee
					  {
						  ID_Employee = x.Id_agent,
						  Phone = x.Phone,
						  Email = x.Email,
						  FName = x.FName,
						  LName = x.LName,
						  PassportData = x.PassportData
					  }).ToList<Employee>();

			return rr;
		}

		//add сотруд
		public static int InsertEmployee(string FName, string LName, string Passport, string Phone, string Email)
		{
			int result = employeeAdap.Insert(FName, LName, Passport, Phone, Email);
			employeeAdap.Fill(employeeTable);
			return result;
		}

		//спис отел
		public static List<Hotel> GetHotels()
		{
			return hotelTable.Select(delegate (DBTourDataSet.HotelRow x)
			{
				Hotel hotel = new Hotel();
				hotel.id_hotel = x.ID_hotel;
				hotel.City = x.City;
				hotel.Information = x.Information;
				hotel.Name = x.HotelName;
				hotel._Country = new Country
				{
					country_id = x.Country_ID,
					Name = x.CountryRow.Name
				};
				hotel.Rating = x.Rating;
				hotel._hotelServices = (from y in x.GetHotelServiceRows()
										select new Service
										{
											id_service = y.Service_id,
											Title = y.ServiceRow.Title
										}).ToList<Service>();
				return hotel;
			}).ToList<Hotel>();
		}

        //измен дан отелей
        public static int UpdateHotel(Hotel currentHotel)
        {
            int result = hotelAdap.UpdateQuery(currentHotel.Name, currentHotel._Country.country_id, currentHotel.City, currentHotel.Rating, currentHotel.Information, currentHotel.id_hotel);
            hotelAdap.Fill(hotelTable);
            return result;
        }

        //del отелей
        public static void DeleteHotel(Hotel hotel)
        {
            hotelAdap.DeleteQuery(hotel.id_hotel);
            hotelAdap.Fill(DataAccess.hotelTable);
        }

        //add сервис для отел
        public static void UpdateHotelService(Hotel hotel)
        {
            hsAdap.DeleteQuery(hotel.id_hotel);
            foreach (Service service in hotel._hotelServices)
            {
                hsAdap.Insert(hotel.id_hotel, service.id_service);
            }
            hsAdap.Fill(hsTable);
        }

        //список для поис отел
        public static List<Hotel> GetHotels(string name, Country country, string city, string service)
		{
			IEnumerable<Hotel> source = GetHotels();

			bool flag = name.Length != 0;
			if (flag)
			{
				return source.Select(x => x).Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
			}
			bool flag2 = country != null;
			if (flag2)
			{
				return source.Select(x => x).Where(x => x._Country.country_id == country.country_id).ToList();
			}
			bool flag3 = city.Length != 0;
			if (flag3)
			{
				return source.Select(x => x).Where(x => x.City.ToLower().Contains(city.ToLower())).ToList();
			}
			bool flag4 = service.Length != 0;
			if (flag4)
			{
				return source.Select(x => x).Where(x => x.HotelServices.ToLower().Contains(service.ToLower().Trim())).ToList();
			}
			return source.ToList<Hotel>();
		}

        //встав дан отля
        public static int InsertHotel(Hotel newHotel)
        {
            int result = hotelAdap.InsertQuery(newHotel.Name, newHotel._Country.country_id, newHotel.City, newHotel.Rating, newHotel.Information);
            hotelAdap.Fill(DataAccess.hotelTable);
            bool flag = newHotel._hotelServices.Count > 0;
            if (flag)
            {
				DBTourDataSet.HotelRow hotelRow = (from x in hotelTable
                                               where x.HotelName == newHotel.Name && x.City == newHotel.City && x.Country_ID == newHotel._Country.country_id
                                               select x).FirstOrDefault<DBTourDataSet.HotelRow>();
                bool flag2 = hotelRow != null;
                if (flag2)
                {
                    foreach (Service service in newHotel._hotelServices)
                    {
                        hsAdap.Insert(hotelRow.ID_hotel, service.id_service);
                    }
                    hsAdap.Fill(hsTable);
                }
            }
            return result;
        }

        //список стран соз
        public static List<Country> GetCountry()
		{
			return (from x in countryTable
					select new Country
					{
						country_id = x.ID_country,
						Name = x.Name
					}).ToList<Country>();
		}

		//соз список сервис в отел
		public static List<Service> GetServices()
		{
			return (from x in serviceTable
					select new Service
					{
						id_service = x.ID_Service,
						Title = x.Title
					}).ToList<Service>();
		}

		//соз список туристов
		public static List<Tourist> GetTourists()
		{
			return (from x in touristTable
					select new Tourist
					{
						Email = x.Email,
						FName = x.FName,
						ID_Tourist = x.ID_tourist,
						LName = x.LName,
						PassportData = x.PassportData,
						Phone = x.Phone
					}).ToList<Tourist>();
		}

		//соз спис туров
		public static List<Tour> GetTours()
		{
			return tourTable.Select(delegate (DBTourDataSet.TourRow x)
			{
				Tour tour = new Tour();
				tour.DateBegin = x.DateBegin;
				tour.Information = x.Information;
				tour.DateEnd = x.DateEnd;
				tour.Price = x.Price;
				tour.Seats = x.Seats;
				tour.TourName = x.TourName;
				tour.tour_id = x.ID_Tour;
				tour._Country = new Country
				{
					country_id = x.CountryRow.ID_country,
					Name = x.CountryRow.Name
				};
				Hotel hotel = new Hotel();
				hotel.id_hotel = x.HotelRow.ID_hotel;
				hotel.Name = x.HotelRow.HotelName;
				hotel.City = x.HotelRow.City;
				hotel.Information = x.HotelRow.Information;
				hotel.Rating = x.HotelRow.Rating;
				hotel._hotelServices = (from y in x.HotelRow.GetHotelServiceRows()
										select new Service
										{
											id_service = y.Service_id,
											Title = y.ServiceRow.Title
										}).ToList<Service>();
				hotel._Country = new Country
				{
					country_id = x.HotelRow.Country_ID,
					Name = x.HotelRow.CountryRow.Name
				};
				tour._Hotel = hotel;
				return tour;
			}).ToList<Tour>();
		}

		//поиск по туру по сходству выбраное в спис
		public static List<Tour> GetTours(string name, Country country, decimal price, DateTime dateBegin)
		{
			IEnumerable<Tour> source = GetTours();

			List<Tour> ls = new List<Tour>();

			bool flag = name.Trim().Length > 0;
			if (flag)
			{
				return source.Select(x => x).Where(x => x.TourName.ToLower().Contains(name.ToLower().Trim())).ToList();
			}
			bool flag2 = country != null;
			if (flag2)
			{
				return source.Select(x => x).Where(x => x._Country.country_id == country.country_id).ToList();
			}
			bool flag3 = price > 0m;
			if (flag3)
			{
                return source.Select(x => x).Where(x => x.Price <= price).ToList();
			}
			return source.Select(x => x).Where(x => x.DateBegin >= dateBegin).ToList();
		}

		//спис путиш
		public static List<Travel> GetTravels()
		{
			return travelTable.Select(delegate (DBTourDataSet.TravelRow x)
			{
				Travel travel = new Travel();
				travel.CostTour = x.CostTour;
				travel.DateOfIssue = x.DateOfIssue;
				travel.DiscountedPrice = x.DiscountedPrice;
				travel.Fare = x.Fare;
				travel.id_travel = x.ID_Travel;
				travel.Tourist_ = new Tourist
				{
					Email = x.TouristRow.Email,
					FName = x.TouristRow.FName,
					ID_Tourist = x.TouristRow.ID_tourist,
					LName = x.TouristRow.LName,
					PassportData = x.TouristRow.PassportData,
					Phone = x.TouristRow.Phone
				};
				travel.Employee_ = new Employee
				{
					ID_Employee = x.AgentRow.Id_agent,
					Phone = x.AgentRow.Phone,
					Email = x.AgentRow.Email,
					FName = x.AgentRow.FName,
					LName = x.AgentRow.LName,
					PassportData = x.AgentRow.PassportData
				};
				Tour tour = new Tour();
				tour.DateBegin = x.TourRow.DateBegin;
				tour.Information = x.TourRow.Information;
				tour.DateEnd = x.TourRow.DateEnd;
				tour.Price = x.TourRow.Price;
				tour.Seats = x.TourRow.Seats;
				tour.TourName = x.TourRow.TourName;
				tour.tour_id = x.TourRow.ID_Tour;
				tour._Country = new Country
				{
					country_id = x.TourRow.CountryRow.ID_country,
					Name = x.TourRow.CountryRow.Name
				};
				Hotel hotel = new Hotel();
				hotel.id_hotel = x.TourRow.HotelRow.ID_hotel;
				hotel.Name = x.TourRow.HotelRow.HotelName;
				hotel.City = x.TourRow.HotelRow.City;
				hotel.Information = x.TourRow.HotelRow.Information;
				hotel.Rating = x.TourRow.HotelRow.Rating;
				hotel._hotelServices = (from y in x.TourRow.HotelRow.GetHotelServiceRows()
										select new Service
										{
											id_service = y.Service_id,
											Title = y.ServiceRow.Title
										}).ToList<Service>();
				hotel._Country = new Country
				{
					country_id = x.TourRow.HotelRow.Country_ID,
					Name = x.TourRow.HotelRow.CountryRow.Name
				};
				tour._Hotel = hotel;
				travel.Tour = tour;
				return travel;
			}).ToList<Travel>();
		}

		//таблицы + адап
		
		private static DBTourDataSet dset = new DBTourDataSet();

        private static AgentTableAdapter employeeAdap;

		private static HotelTableAdapter hotelAdap;

		private static CountryTableAdapter countryAdapt;

		private static HotelServiceTableAdapter hsAdap;

	    private static ServiceTableAdapter serviceAdap;

		private static TouristTableAdapter touristAdap;

		private static TourTableAdapter tourAdap;

		private static TravelTableAdapter travelAdap;

		private static DBTourDataSet.AgentDataTable employeeTable = dset.Agent;

		private static DBTourDataSet.HotelDataTable hotelTable = dset.Hotel;

		private static DBTourDataSet.CountryDataTable countryTable = dset.Country;

		private static DBTourDataSet.HotelServiceDataTable hsTable = dset.HotelService;

		private static DBTourDataSet.ServiceDataTable serviceTable = dset.Service;

		private static DBTourDataSet.TouristDataTable touristTable = dset.Tourist;

		private static DBTourDataSet.TourDataTable tourTable = dset.Tour;

		private static DBTourDataSet.TravelDataTable travelTable = dset.Travel;
	}
}
