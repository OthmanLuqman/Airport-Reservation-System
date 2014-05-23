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
    public partial class MainPage_Base : Form
    {
        protected ReservationSystem reservationSystem;
        public MainPage_Base(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;
            InitializeComponent();
        }

        public MainPage_Base()
        {
            InitializeComponent();
        }

        private void MainPage_Base_Load(object sender, EventArgs e)
        {

        }
    }
}
