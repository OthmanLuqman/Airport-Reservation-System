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
    public partial class MainPage_Salesman : MainPage_Base
    {
        public MainPage_Salesman(ReservationSystem reservationSystem)
            : base(reservationSystem)
        {
            InitializeComponent();
        }

        private void MainPage_Salesman_Load(object sender, EventArgs e)
        {

        }




        private void UpdateTablesButton_Click(object sender, EventArgs e)
        {
            reservationSystem.UpdateTables();
        }

        private void ReserveButton_Click_1(object sender, EventArgs e)
        {
            new AddReservationPage(reservationSystem).ShowDialog();
        }

        private void CancelReservationButton_Click_1(object sender, EventArgs e)
        {
            new CancelReservationPage(reservationSystem).ShowDialog();
        }

        private void DisplayFlightsButton_Click(object sender, EventArgs e)
        {
            new DisplayFlightsPage(reservationSystem).ShowDialog();

        }

        private void DisplayReservationsButton_Click(object sender, EventArgs e)
        {
            new DisplayReservationsPage(reservationSystem).ShowDialog();

        }

        private void DisplayAirplanesButton_Click(object sender, EventArgs e)
        {
            new DisplayAirplanesPage(reservationSystem).ShowDialog();

        }

        private void DisplayAirportsButton_Click(object sender, EventArgs e)
        {
            new DisplayAirportsPage(reservationSystem).ShowDialog();

        }


    }
}
