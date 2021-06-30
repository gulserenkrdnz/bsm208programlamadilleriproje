using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReservationForm.Admin
{
    public partial class Add_Flight : Form
    {
        public Add_Flight()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            this.Visible = false;
            adminPage.ShowDialog();
            this.Close();
        }

        private void addflight_Click(object sender, EventArgs e)
        {
            FlightManager flightManager = new FlightManager(new EfFlightDal());
            DestinationCityManager desManager = new DestinationCityManager(new EfDestinationCityDal());
            DepartureCityManager depManager = new DepartureCityManager(new EfDepartureCityDal());
            FirmManager firmManager = new FirmManager(new EfFirmDal());

            Flight flight = new Flight();

            DestinationCity desCity = desManager.GetByName(entryDesCity.Text.Trim().ToString());
            DepartureCity depCity = depManager.GetByName(entryDepCity.Text.Trim().ToString());
            Firm firm = firmManager.GetByName(entryFirm.Text.Trim().ToString());

            int desID = desCity.ID;
            int depID = depCity.ID;
            int firmID = firm.ID;
            int ePrice = int.Parse(EcoPrice.Text);
            flight.FirmID = firmID;
            flight.DestinationCityID = desID;
            flight.DepartureCityID = depID;
            flight.DepartureDate = DapartureD.Value;
            flight.DepartureTime = DepartureT.Text.ToString();
            flight.ArrivalTime = ArrivalT.Text.ToString();
            flight.EcoPrice = ePrice;
            flight.BusinessPrice = Convert.ToInt32(BusinessPrice.Text.ToString());

            flightManager.Add(flight);
            MessageBox.Show("Kayıt başalrılı.");

        }

        private void Add_Flight_Load(object sender, EventArgs e)
        {
            DestinationCityManager cityManager = new DestinationCityManager(new EfDestinationCityDal());

            foreach (var city in cityManager.GetAll())
            {
                entryDepCity.Items.Add(city.CityName);
                entryDesCity.Items.Add(city.CityName);
            }
        }
    }
    }

