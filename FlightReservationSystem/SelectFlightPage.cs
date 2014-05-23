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
    public delegate void IDSelectionCallBack(Guid ID);
    public partial class SelectFlightPage : DisplayFlightsPage
    {
        public SelectFlightPage(ReservationSystem reservationSystem)
            : base(reservationSystem)
        {
            InitializeComponent();
        }

        public void SetIIDSelectionCallBack(IDSelectionCallBack c)
        {
            idSelectionCallBack = c;
        }

        public SelectFlightPage()
        {
            InitializeComponent();
        }

        private void FlightSelectionPage_Load(object sender, EventArgs e)
        {

        }



        protected void OnRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Guid ID = Guid.Parse(FlightGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            if(idSelectionCallBack!=null)
                this.idSelectionCallBack(ID);
            this.Close();
            
        }


        private IDSelectionCallBack idSelectionCallBack = null;
    }
}
