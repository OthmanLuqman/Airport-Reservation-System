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
    public partial class AddPlanePage : Form
    {
        ReservationSystem reservationSystem;
        public AddPlanePage(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;
            InitializeComponent();
        }

        private void AddPlanePage_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String name = NameTextBox.Text;
            Guid companyID = Guid.Parse(CopmanyIDTextBox.Text);
            uint capacity = uint.Parse(CapacityTextBox.Text);

            reservationSystem.AddAirplane(name, companyID, capacity);
        }

        private void SearchCompanyIDButton_Click(object sender, EventArgs e)
        {
            SelectCopmanyPage c = new SelectCopmanyPage(reservationSystem);
            c.SetIIDSelectionCallBack(new IDSelectionCallBack(SetCompanyID));
            c.Show();
        }

        public void SetCompanyID(Guid ID)
        {
            this.CopmanyIDTextBox.Text = ID.ToString();
            MessageBox.Show("Guid is " + ID);
        }

    }
}
