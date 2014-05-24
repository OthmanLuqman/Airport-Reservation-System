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
    public partial class MainPage_Manager : MainPage_Base
    {

        public MainPage_Manager(ReservationSystem reservationSystem)
            : base(reservationSystem)
        {
            InitializeComponent();
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            new AddReservationPage(reservationSystem).ShowDialog();
            //this.Close();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void AddAirportButton_Click(object sender, EventArgs e)
        {
            new AddAirportPage(reservationSystem).ShowDialog();
            //this.Close();
        }

        private void AddStaffButton_Click(object sender, EventArgs e)
        {
            new AddStaffPage(reservationSystem).ShowDialog();
        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            new AddFlightPage(reservationSystem).ShowDialog();
        }

        private void AddAirplaneButton_Click(object sender, EventArgs e)
        {
            new AddPlanePage(reservationSystem).ShowDialog();
        }

        private void CancelReservationButton_Click(object sender, EventArgs e)
        {
            new CancelReservationPage(reservationSystem).ShowDialog();
        }


        private void DisplayFlightsButton_Click(object sender, EventArgs e)
        {
            new DisplayFlightsPage(reservationSystem).ShowDialog();
        }

        private void DisplayCompaniesButton_Click(object sender, EventArgs e)
        {
            new DisplayCompaniesPage(reservationSystem).ShowDialog();
        }

        private void DisplayAirportsButton_Click(object sender, EventArgs e)
        {
            new DisplayAirportsPage(reservationSystem).ShowDialog();
        }

        private void DisplayReservationsButton_Click(object sender, EventArgs e)
        {
            new DisplayReservationsPage(reservationSystem).ShowDialog();
        }

        private void DisplayStaffsButton_Click(object sender, EventArgs e)
        {
            new DisplayStaffsPage(reservationSystem).ShowDialog();
        }

        private void DisplayAirplanesButton_Click(object sender, EventArgs e)
        {
            new DisplayAirplanesPage(reservationSystem).ShowDialog();
        }

        private void UpdateTablesButton_Click(object sender, EventArgs e)
        {
            reservationSystem.UpdateTables();
        }

        private void AddCompanyButton_Click(object sender, EventArgs e)
        {
            new AddCompanyPage(reservationSystem).ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

    }
}
