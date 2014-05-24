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
    public partial class DisplayCompaniesPage : Form
    {
        ReservationSystem reservationSystem;
        public DisplayCompaniesPage(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;
            InitializeComponent();
            InitialTables();
        }

        public DisplayCompaniesPage( )
        {
            InitializeComponent();
        }

        private void InitialTables()
        {
            DataTable dt = reservationSystem.GetCompaniesTable();

            InitialOriginalTable(dt);

            queriedTable = originalTable.Copy();
            
            CompanyGridView.DataSource = queriedTable;
            CompanyGridView.Columns["ID"].Visible = false;
            CompanyGridView.Columns["Name"].HeaderText = "نام شرکت";
        }

        private void InitialOriginalTable(DataTable dt)
        {

            originalTable = dt.Copy();

        }


        private void DisplayCompaniesPage_Load(object sender, EventArgs e)
        {

        }

        DataTable originalTable = null;
        DataTable queriedTable = null;
    }
}
