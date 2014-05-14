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
    public partial class LoginPage : Form
    {
        ReservationSystem reservationSystem;
        public LoginPage(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(reservationSystem.Login(UsernameTextBox.Text, PasswordTextBox.Text))
            {
                this.Close();
                new MainPage().Show();
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
