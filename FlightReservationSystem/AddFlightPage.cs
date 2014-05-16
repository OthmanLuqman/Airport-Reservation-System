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

            reservationSystem.AddFlight(planeID, originAirportID, destinationAirportID, departureDate, arrivalDate);
        }


    }
}
