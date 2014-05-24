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
    public partial class AddAirportPage : Form
    {
        ReservationSystem reservationSystem;
        public AddAirportPage(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String name = NameTextBox.Text;
            String country = CountryTextBox.Text;
            String city = CityTextBox.Text;

            reservationSystem.AddAirport(name, new Location(country, city));
            this.Close();
        }
    }
}
