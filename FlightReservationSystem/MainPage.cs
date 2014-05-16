using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationSystem
{
    public partial class MainPage : Form
    {
        ReservationSystem reservationSystem;

        public MainPage(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;
            InitializeComponent();
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            new ReservationPage(reservationSystem).Show();
            this.Close();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void AddAirportButton_Click(object sender, EventArgs e)
        {
            new AddAirportPage(reservationSystem).Show();
            //this.Close();
        }

        private void AddStaffButton_Click(object sender, EventArgs e)
        {
            new AddStaffPage(reservationSystem).Show();
        }
    }
}
