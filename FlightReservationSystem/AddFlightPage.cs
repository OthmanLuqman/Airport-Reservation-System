using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationSystem
{
    public partial class AddFlightPage : Form
    {
        ReservationSystem reservationSystem;
        public AddFlightPage(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;
            InitializeComponent();
        }

        private void DepartureTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Guid planeID = Guid.Parse(PlaneIDTextBox.Text);
            Guid originAirportID = Guid.Parse(OriginAirportTextBox.Text);
            Guid destinationAirportID = Guid.Parse(DestinationAirportTextBox.Text);
            DateTime departureDate = DepartureTimePicker.Value;
            DateTime arrivalDate = ArrivalTimePicker.Value;
            uint cost = uint.Parse(CostTextBox.Text);

            reservationSystem.AddFlight(planeID, originAirportID, destinationAirportID, departureDate, arrivalDate, cost);
            this.Close();
        }

        private void SearchPlaneIDButton_Click(object sender, EventArgs e)
        {
            SelectAirplanePage a = new SelectAirplanePage(reservationSystem);
            a.SetIIDSelectionCallBack(new IDSelectionCallBack(SetPlaneID));
            a.ShowDialog();
        }

        public void SetPlaneID(Guid ID)
        {
            this.PlaneIDTextBox.Text = ID.ToString();
            //MessageBox.Show("Guid is " + ID);
        }


        private void SearchOriginAirportIDButton_Click(object sender, EventArgs e)
        {
            SelectAirportPage a = new SelectAirportPage(reservationSystem);
            a.SetIIDSelectionCallBack(new IDSelectionCallBack(SetOriginAirportID));
            a.ShowDialog();
        }

        public void SetOriginAirportID(Guid ID)
        {
            this.OriginAirportTextBox.Text = ID.ToString();
            //MessageBox.Show("Guid is " + ID);
        }

        private void SearchDestinationAirportIDButton_Click(object sender, EventArgs e)
        {
            SelectAirportPage a = new SelectAirportPage(reservationSystem);
            a.SetIIDSelectionCallBack(new IDSelectionCallBack(SetDestinationAirportID));
            a.ShowDialog();
        }

        public void SetDestinationAirportID(Guid ID)
        {
            this.DestinationAirportTextBox.Text = ID.ToString();
            //MessageBox.Show("Guid is " + ID);
        }

    }
}
