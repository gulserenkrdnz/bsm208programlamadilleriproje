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
    public partial class FlightList : Form
    {
        public FlightList()
        {
            InitializeComponent();
        }

        String stdDetails = "{0}{1}{2}{3}{4}{5}{6}{7}";

        public static DepartureCity DepartureCity { get; set; }
        public static DestinationCity DestinationCity { get; set; }

        private void FlightList_Load(object sender, EventArgs e)
        {
            FlightManager flightManager = new FlightManager(new EfFlightDal());
            List<Flight> flights = flightManager.GetAllByCityId(DepartureCity.ID, DestinationCity.ID);

            foreach (var item in flights)
            {
                DepartureCity DepartureCity = 
                TheList.Items.Add(String.Format());
            }
        }

        /*
       private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
       {

           switch (Agency.Text)
           {
               case " A Acentası": KoltukDoldur(8, false);
                   break;
               case "B Acentası": KoltukDoldur(12, true);
                   break;
               case "C Acentası": KoltukDoldur(10, false);
                   break;
           }
           void KoltukDoldur(int desk, bool rearfive)
           {
               slow:
               foreach (Control ctrl in this.Controls)
               {
                   if(ctrl is Button)
                   {
                       Button btn = ctrl as Button;
                       if(btn.Text=="Kaydet")
                       {
                           continue;
                       }
                     else
                       {
                           this.Controls.Remove(ctrl);
                           goto slow;
                       }
                   }
               }
                int seatNo = 1;

               for (int i = 0; i<desk; i++)
               {
               for(int j=0;j<5;i++)
                   {
                       if(rearfive==true)
                       {
                           if(i  !=desk-1 && j==2)
                           {
                               continue;
                           }
                       }
                       else
                       {
                           if (j == 2)
                               continue;
                       }

                       Button seat = new Button();
                       seat.Height = seat.Width = 40;
                       seat.Top = 30 * (i * 45);
                       seat.Left = 5 * (j * 45);
                       seat.Text = seatNo.ToString();
                       seatNo++;
                       seat.ContextMenuStrip = contextMenuStrip1;
                       this.Controls.Add(seat);
                   }
           }

           }
       }
*/
        /*       private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
               {
                   if (Agency.SelectedIndex == -1 || departurePoint.SelectedIndex == -1 || destination.SelectedIndex == -1)
                   {
                       MessageBox.Show("Lütfen önce gerekli alanları doldurun");
                           return;

                   }
                   Show_Reservation Reservation = new Show_Reservation();
                   DialogResult sonuc= Reservation.ShowDialog();
               }
       */

    }
}
