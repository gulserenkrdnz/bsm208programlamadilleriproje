using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using Entities.Concreate.DTOs;
using ReservationForm.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReservationForm.Admin
{
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            this.Visible = false;
            adminPage.ShowDialog();
            this.Close();
        }


        private void Reservations_Load(object sender, EventArgs e)
        {

            SeatManager seatManager = new SeatManager(new EfSeatDal());
            List<ReservationDetails> reservations = seatManager.GetReservationDetails();

            foreach (var item in reservations)
            {
                if (item.UserID == AdminLogin.LoggedAdmin.ID)
                {
                    int id = item.UserID;
                    string firm = item.FirmName;
                    string departureCity = item.DepartureCity;
                    string destinationCity = item.DestinationCity;
                    DateTime? dateTime = (DateTime)item.DepartureDate;
                    string departureTime = item.DepartureTime;
                    string arrivalTime = item.ArrivalTime;
                    string name = item.Name;
                    string lastname = item.LastName;
                    int ecoPrice = item.Price;
                    string seatNo = item.SeatNo.ToString();


                    TheList.Items.Add(id.ToString()).SubItems.AddRange(
                        new string[] { firm, seatNo, departureCity, destinationCity, dateTime.ToString(),
                        departureTime, name, lastname, ecoPrice.ToString()});
                }
            }
        }
    }
}
