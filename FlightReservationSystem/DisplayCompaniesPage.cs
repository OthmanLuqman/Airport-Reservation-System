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

            //InitialOriginalTable(dt);

            //queriedTable = originalTable.Copy();
            
            CompanyGridView.DataSource = dt;
            CompanyGridView.Columns["ID"].Visible = false;
        }

        private void InitialOriginalTable(DataTable dt)
        {

            originalTable = new DataTable();
            originalTable.Columns.Add("OriginCountry");
            originalTable.Columns.Add("OriginCity");
            originalTable.Columns.Add("OriginAirport");
            originalTable.Columns.Add("DestinationCountry");
            originalTable.Columns.Add("DestinationCity");
            originalTable.Columns.Add("DestinationAirport");
            originalTable.Columns.Add("DepartureDate");
            originalTable.Columns.Add("ArrivalDate");
            originalTable.Columns.Add("Plane");
            originalTable.Columns.Add("Cost");

            foreach (DataRow row in dt.Rows)
            {

                Guid originAirportID = Guid.Parse(row["originAirportID"].ToString());
                Airport originAirport = reservationSystem.GetAirportByID(originAirportID);
                String originCountry = originAirport.location.country;
                String originCity = originAirport.location.city;
                String originAirportName = originAirport.name;

                Guid destinationAirportID = Guid.Parse(row["destinationAirportID"].ToString());
                Airport destinationAirport = reservationSystem.GetAirportByID(destinationAirportID);
                String destinationCountry = destinationAirport.location.country;
                String destinationCity = destinationAirport.location.city;
                String destinationAirportName = destinationAirport.name;

                String departureDate = row["departureDate"].ToString();
                String arrivalDate = row["arrivalDate"].ToString();

                Guid planeID = Guid.Parse(row["planeID"].ToString());
                String planeName = reservationSystem.GetPlaneByID(planeID).name;

                originalTable.Rows.Add(originCountry
                    , originCity
                    , originAirportName
                    , destinationCountry
                    , destinationCity
                    , destinationAirportName
                    , departureDate
                    , arrivalDate
                    , planeName);

            }

        }


        private void DisplayCompaniesPage_Load(object sender, EventArgs e)
        {

        }

        DataTable originalTable = null;
        DataTable queriedTable = null;
    }
}
