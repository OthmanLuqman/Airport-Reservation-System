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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Rank loggedInRank = reservationSystem.Login(UsernameTextBox.Text, PasswordTextBox.Text);

            if (loggedInRank == Rank.Manager)
            {
                this.Hide();
                var mainPage = new MainPage_Manager(reservationSystem);
                mainPage.Closed += (sender2, args) => this.Close();
                mainPage.Show();
            }
            else if (loggedInRank == Rank.Salesman)
            {

                this.Hide();
                var mainPage = new MainPage_Salesman(reservationSystem);
                mainPage.Closed += (sender2, args) => this.Close();
                mainPage.Show();
            }
        }


        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
