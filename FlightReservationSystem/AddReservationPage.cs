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
    public partial class AddReservationPage : Form
    {
        ReservationSystem reservationSystem;
        public AddReservationPage(ReservationSystem reservationSystem)
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
            Gender gender = Utilities.StringToGender(PersianSexToEnglishSex(SexComboBox.Text));
            String nationalCode = NationalCodeTextBox.Text;

            uint seatNumber = uint.Parse(SeatNumberTestBox.Text);

            reservationSystem.AddReservation(flightID, fName, lName, age, gender, nationalCode, seatNumber);
        }

        private String PersianSexToEnglishSex(String sexStr)
        {
            if (sexStr == "")
                return "";

            Dictionary<String, String> convertor = new Dictionary<string,string>();
            convertor.Add("مرد", "male");
            convertor.Add("زن", "female");
            return convertor[sexStr];

            
        }

        private void ReservationPage_Load(object sender, EventArgs e)
        {

        }

        private void FlightSearchButton_Click(object sender, EventArgs e)
        {
            SelectFlightPage f = new SelectFlightPage(reservationSystem);
            f.SetIIDSelectionCallBack(new IDSelectionCallBack(SetFlightID));
            f.ShowDialog();
            
        }

        public void SetFlightID(Guid ID)
        {
            this.FlightIDTextBox.Text = ID.ToString();
           MessageBox.Show("Guid is " + ID);
        }

        private void SearchSeatsButton_Click(object sender, EventArgs e)
        {
            List<bool> seats = new List<bool>();
            seats.Add(true);
            seats.Add(true);
            seats.Add(true);
            seats.Add(true);
            seats.Add(true);
            seats.Add(true);
            seats.Add(true);
            seats.Add(true);
            seats.Add(false);
            seats.Add(false);
            seats.Add(false);
            seats.Add(false);
            seats.Add(false);
            seats.Add(false);
            seats.Add(false);
            seats.Add(false);
            seats.Add(false);
            seats.Add(false);

            new DisplaySeatsPage(seats,seats.Count, 2).ShowDialog();
        }
    }
}
