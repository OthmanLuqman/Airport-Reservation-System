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
    public partial class CancelReservationPage : Form
    {
        ReservationSystem reservationSystem;
        public CancelReservationPage(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;
            InitializeComponent();
        }

        private void CancelReservationButton_Click(object sender, EventArgs e)
        {
            Guid reservationID = Guid.Parse(ReservationIDTextBox.Text);

            reservationSystem.CancelReservation(reservationID);
        }
    }
}
