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
    public partial class ReservationPage : Form
    {
        ReservationSystem reservationSystem;
        public ReservationPage(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            Guid flightID = Guid.Parse(FlightIDTextBox.Text);
            String fName = FirstNameTextBox.Text;
            String lName = LastNameTextBox.Text;
            uint age  = uint.Parse(AgeTextBox.Text);
            Gender gender = Utilities.StringToGender(GenderTextBox.Text);
            String nationalCode = NationalCodeTextBox.Text;

            List<uint> seats = new List<uint>();

            reservationSystem.ReserveFlight(flightID, fName, lName, age, gender, nationalCode,seats);
        }


        private void ReservationPage_Load(object sender, EventArgs e)
        {

        }
    }
}
