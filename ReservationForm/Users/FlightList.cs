using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using Entities.Concreate;
using Entities.Concreate.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReservationForm.Users
{
    public partial class FlightList : Form
    {
        public FlightList()
        {
            InitializeComponent();
        }

        //String stdDetails = "{0}{1}{2}{3}{4}{5}{6}{7}";

        public static DepartureCity DepartureCity { get; set; }
        public static DestinationCity DestinationCity { get; set; }
        public static string FlightId;

        private void FlightList_Load(object sender, EventArgs e)
        {
            FlightManager flightManager = new FlightManager(new EfFlightDal());
            List<FlightListElement> flights = flightManager.GetFlightDetails();

            foreach (var item in flights)
            {
                if (item.DestinationCity == FlightList.DestinationCity.CityName && item.DepartureCity == DepartureCity.CityName)
                {
                    int id = item.FlightID;
                    string firm = item.FirmName;
                    string departureCity = item.DepartureCity;
                    string destinationCity = item.DestinationCity;
                    DateTime? dateTime = (DateTime)item.DepartureDate;
                    string departureTime = item.DepartureTime;
                    string arrivalTime = item.ArrivalTime;
                    decimal ecoPrice = item.EcoPrice;
                    decimal businessPrice = item.BusinessPrice;

                    TheList.Items.Add(id.ToString()).SubItems.AddRange(
                        new string[] { firm, departureCity, destinationCity, dateTime.ToString(),
                        departureTime, arrivalTime, ecoPrice.ToString(), businessPrice.ToString() });
                }
            }
            SeatManager seatManager = new SeatManager(new EfSeatDal());

            List<Seat> seats = seatManager.GetSeatsByFlightId(Convert.ToInt32(FlightId));

       /*     if(FlightId != null)
            {
                foreach (var item in seats)
                {
                    groupBox1.
                }
            }*/
        }

        private void col1_CheckedChanged(object sender, EventArgs e)
        {
            FlightId = TheList.Items[0].ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FlightId = TheList.Items[1].ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            FlightId = TheList.Items[2].ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            FlightId = TheList.Items[3].ToString();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

            FlightId = TheList.Items[4].ToString();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            FlightId = TheList.Items[5].ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            FlightId = TheList.Items[6].ToString();
        }


        

    }
}
