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
    public partial class MainPage : MainPage_Base
    {
        public MainPage(ReservationSystem reservationSystem)
            : base(reservationSystem)
        {
            InitializeComponent();
        }

        private void MainPage_Salesman_Load(object sender, EventArgs e)
        {

        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            new AddReservationPage(reservationSystem).Show();
        }

        private void CancelReservationButton_Click(object sender, EventArgs e)
        {
            new CancelReservationPage(reservationSystem).Show();
        }
    }
}
