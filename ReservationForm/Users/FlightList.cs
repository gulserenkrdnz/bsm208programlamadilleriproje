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


        public static DepartureCity DepartureCity { get; set; }
        public static DestinationCity DestinationCity { get; set; }
        public static int FlightId;
        public static Agency agency;
        public static int SeatNo;

        private void FlightList_Load(object sender, EventArgs e)
        {
            ListFlights();

           



        }

       

       
        private void col1_CheckedChanged(object sender, EventArgs e)
        {
            FlightId = Convert.ToInt32(TheList.Items[0].Text);
            FillSeats1();
            FillSeats2();
            FillSeats3();
            
        }

       
        private void FillSeats1()
        {
            SeatManager seatManager = new SeatManager(new EfSeatDal());
            List<Seat> seats = seatManager.GetSeatsByFlightId(FlightId);

            int counter = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button seatButton = new Button();
                    seatButton.Height = seatButton.Width = 40;
                    seatButton.Top = 40 + (i * 45);
                    seatButton.Left = 35 + (j * 45);
                    seatButton.Text = counter.ToString();
                    seatButton.Name = (counter * 10).ToString();
                    foreach (var item in seats)
                    {
                        if (item.SeatNo == counter)
                        {
                            seatButton.BackColor = Color.Red;
                        }
                    }
                    groupBox1.Controls.Add(seatButton);
                    counter++;
                }
            }
        }

        private void FillSeats2()
        {
            SeatManager seatManager = new SeatManager(new EfSeatDal());
            List<Seat> seats = seatManager.GetSeatsByFlightId(FlightId);

            int counter = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button seatButton = new Button();
                    seatButton.Height = seatButton.Width = 40;
                    seatButton.Top = 40 + (i * 45);
                    seatButton.Left = 35 + (j * 45);
                    seatButton.Text = counter.ToString();
                    seatButton.Name = (counter * 100).ToString();
                    foreach (var item in seats)
                    {
                        if (item.SeatNo == counter)
                        {
                            seatButton.BackColor = Color.Red;
                        }
                    }
                    groupBox2.Controls.Add(seatButton);
                    counter++;
                }
            }
        }

        private void FillSeats3()
        {
            SeatManager seatManager = new SeatManager(new EfSeatDal());
            List<Seat> seats = seatManager.GetSeatsByFlightId(FlightId);

            int counter = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button seatButton = new Button();
                    seatButton.Height = seatButton.Width = 40;
                    seatButton.Top = 40 + (i * 45);
                    seatButton.Left = 35 + (j * 45);
                    seatButton.Text = counter.ToString();
                    seatButton.Name = (counter * 1000).ToString();
                    SeatNo = counter;
                    foreach (var item in seats)
                    {
                        if (item.SeatNo == counter)
                        {
                            seatButton.BackColor = Color.Red;
                        }
                    }
                    groupBox3.Controls.Add(seatButton);
                    
                    counter++;
                }
            }
        }

        private void ListFlights()
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
        }


        private void back_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            this.Visible = false;
            search.ShowDialog();
            this.Close();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FlightId = Convert.ToInt32(TheList.Items[1].Text);
            FillSeats1();
            FillSeats2();
            FillSeats3();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            FlightId = Convert.ToInt32(TheList.Items[2].Text);
            FillSeats1();
            FillSeats2();
            FillSeats3();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            FlightId = Convert.ToInt32(TheList.Items[3].Text);
            FillSeats1();
            FillSeats2();
            FillSeats3();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

            FlightId = Convert.ToInt32(TheList.Items[4].Text);
            FillSeats1();
            FillSeats2();
            FillSeats3();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            FlightId = Convert.ToInt32(TheList.Items[5].Text);
            FillSeats1();
            FillSeats2();
            FillSeats3();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            FlightId = Convert.ToInt32(TheList.Items[6].Text);
            FillSeats1();
            FillSeats2();
            FillSeats3();
        }

    }
}
