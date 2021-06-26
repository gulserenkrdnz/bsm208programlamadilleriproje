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
            Add_Flight add = new Add_Flight();

            MessageBox.Show("0.");
     /*       if (add.Firm.Text.ToString().Length > 0 && add.Destination.Text.ToString().Length > 0 
                && add.DepartureT.Text.ToString().Length > 0 && add.Departure.Text.ToString().Length > 0 
                && add.ArrivalT.Text.ToString().Length > 0 && add.DepartureD.Text.ToString().Length > 0
                && add.EcoPrice.Text.ToString().Length > 0 && add.BusinessPrice.Text.ToString().Length > 0)
            {*/
                int desID = Convert.ToInt32(desManager.GetByName(add.Destination.Text.ToString()));
                int depID = Convert.ToInt32(depManager.GetByName(add.Departure.Text.ToString()));
                int firmID = Convert.ToInt32(firmManager.GetByName(add.Firm.Text.ToString()));

                int eprice = Convert.ToInt32(add.EcoPrice.Text.ToString());

                MessageBox.Show(eprice.ToString());
                flight.FirmID = firmID;
                flight.DestinationCityID = desID;
                flight.DepartureCityID = depID;
                flight.DepartureDate = add.DapartureD.Value;
                flight.DepartureTime = add.DepartureT.Text.ToString();
                flight.ArrivalTime = add.ArrivalT.Text.ToString();
                flight.EcoPrice = eprice;
                flight.BusinessPrice = Convert.ToInt32(add.BusinessPrice.Text.ToString());

                flightManager.Add(flight);
                MessageBox.Show("Kayıt başalrılı.");
      //     }
     //       else
      //      {
      //          MessageBox.Show("Başarısız.");
      //      }
         
            }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

