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
    public partial class DisplayAirplanesPage : Form
    {
        ReservationSystem reservationSystem;

        public DisplayAirplanesPage()
        {
            InitializeComponent();
        }


        public DisplayAirplanesPage(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;
            InitializeComponent();
            InitialTables();
        }

        private void InitialTables()
        {
            DataTable dt = reservationSystem.GetAirplanesTable();

            InitialOriginalTable(dt);

            queriedTable = originalTable.Copy();
            PlanesGridView.DataSource = queriedTable;
            PlanesGridView.Columns["ID"].Visible = false;
            PlanesGridView.Columns["CompanyID"].Visible = false;
        }

        private void InitialOriginalTable(DataTable dt)
        {
            originalTable = dt.Copy();
            originalTable.Columns.Add("CompanyName");

            foreach(DataRow row in originalTable.Rows)
            {
                Guid companyID = Guid.Parse(row["CompanyID"].ToString());
                Company company = reservationSystem.GetCompanyByID(companyID);
                String companyName = company.name;
                row["CompanyName"] = companyName;
            }


        }

        private void DisplayAirPlanes_Load(object sender, EventArgs e)
        {

        }

        DataTable queriedTable;
        DataTable originalTable;
    }
}
