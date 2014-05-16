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
    public partial class AddCompanyPage : Form
    {
        ReservationSystem reservationSystem;
        public AddCompanyPage(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;
            InitializeComponent();
        }

        private void AddCompany_Click(object sender, EventArgs e)
        {
            String companyName = CompanyNameTextBox.Text;
            reservationSystem.AddCompany(companyName);
        }
    }
}
