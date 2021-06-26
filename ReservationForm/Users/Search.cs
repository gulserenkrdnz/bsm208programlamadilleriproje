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

namespace ReservationForm.Users
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Back_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.ShowDialog();
            this.Close();
        }

        private void SearchTicket_Click(object sender, EventArgs e)
        {
            FlightList flightList = new FlightList();
            this.Visible = false;
            flightList.ShowDialog();
            this.Close();
        }


        private void Back_Login_Click_1(object sender, EventArgs e)
        {
            Login Login = new Login();
            this.Visible = false;
            Login.ShowDialog();
            this.Close();
        }

        private void SearchTicket_Click_1(object sender, EventArgs e)
        {
            FlightList flightList = new FlightList();
            this.Visible = false;
            flightList.ShowDialog();
            this.Close();
        }

        private void goReservations_Click(object sender, EventArgs e)
        {
            Show_Reservation reservations = new Show_Reservation();
            this.Visible = false;
            reservations.ShowDialog();
            this.Close();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            DestinationCityManager cityManager = new DestinationCityManager(new EfDestinationCityDal());

            foreach (var city in cityManager.GetAll())
                {
                    DepartureCity.Items.Add(city.CityName);
                    DestinationCity.Items.Add(city.CityName);
                }
        }

        private void DepartureCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departureCity = DepartureCity.Text;

            DepartureCityManager cityManager = new DepartureCityManager(new EfDepartureCityDal());

            FlightList.DepartureCity = cityManager.GetByName(departureCity);
        }

        private void DestinationCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string destinationCity = DestinationCity.Text;

            DestinationCityManager cityManager = new DestinationCityManager(new EfDestinationCityDal());

            FlightList.DestinationCity = cityManager.GetByName(destinationCity);
        }
    }
}
