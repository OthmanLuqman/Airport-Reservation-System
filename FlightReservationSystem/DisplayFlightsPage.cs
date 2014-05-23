using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationSystem
{
    public partial class DisplayFlightsPage : Form
    {

        struct QueryInfo
        {
            public QueryInfo(String originCountry, String originCity,
                             String originAirportName, String destinationCoutry,
                             String destinationCity, String destinationAirportName,
                             String departureDate, String departureTime,
                             String arrivalDate, String arrivalTime)
            {
                this.originCountry = originCountry;
                this.originCity = originCity;
                this.originAirportName = originAirportName;
                this.destinationCoutry = destinationCoutry;
                this.destinationCity = destinationCity;
                this.destinationAirportName = destinationAirportName;
                this.departureDate = departureDate;
                this.departureTime = departureTime;
                this.arrivalDate = arrivalDate;
                this.arrivalTime = arrivalTime;

            }

            public String originCountry;
            public String originAirportName;
            public String originCity;
            public String destinationCoutry;
            public String destinationCity;
            public String destinationAirportName;
            public String departureDate;
            public String departureTime;
            public String arrivalDate;
            public String arrivalTime;



        };

        ReservationSystem reservationSystem;

        public DisplayFlightsPage()
        {
            InitializeComponent();
        }

        public DisplayFlightsPage(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;
            InitializeComponent();
            InitialTables();
        }



        private void InitialTables()
        {
            DataTable dt = reservationSystem.GetFlightsTable();

            InitialOriginalTable(dt);

            queriedTable = originalTable.Copy();
            FlightGridView.DataSource = queriedTable;

            FlightGridView.Columns["ID"].Visible = false;
            FlightGridView.Columns["State"].Visible =false;

            AddStateColoumn();
            //AddActualDatesColoumn();
        }

        private void AddStateColoumn()
        {
            //originalTable.Columns.Add("State");

            stateComboBox = new DataGridViewComboBoxColumn();
            stateComboBox.HeaderText = "وضعیت";
            stateComboBox.Name = "StateComboBox";
            stateComboBox.MaxDropDownItems = 4;
            stateComboBox.Items.Add("در حال پرواز");
            stateComboBox.Items.Add("با تاخیر");
            stateComboBox.Items.Add("طبق قرار");
            stateComboBox.Items.Add("رسیده");


            FlightGridView.Columns.Add(stateComboBox);
            UpdateStateColumn();
        }

        
        private void UpdateStateColumn()
        {
            foreach (DataGridViewRow row in FlightGridView.Rows)
            {

                String stateStr = "";
                if (row.Cells["State"].Value != null)
                    stateStr = row.Cells["State"].Value.ToString().ToLower();
                switch (stateStr)
                {
                    case "enroute":
                        row.Cells["StateComboBox"].Value = stateComboBox.Items[0];
                        break;
                    case "delayed":
                        row.Cells["StateComboBox"].Value = stateComboBox.Items[1];
                        break;
                    case "scheduled":
                        row.Cells["StateComboBox"].Value = stateComboBox.Items[2];
                        break;
                    case "arrived":
                        row.Cells["StateComboBox"].Value = stateComboBox.Items[3];
                        break;

                }
            }
        }
        
        private void AddActualDatesColoumn()
        {
            CalendarColumn c = new CalendarColumn();
            FlightGridView.Columns.Add(c);
        }

        private void InitialOriginalTable(DataTable dt)
        {

            originalTable = new DataTable();
            originalTable.Columns.Add("ID");
            originalTable.Columns.Add("OriginCountry");
            originalTable.Columns.Add("OriginCity");
            originalTable.Columns.Add("OriginAirport");
            originalTable.Columns.Add("DestinationCountry");
            originalTable.Columns.Add("DestinationCity");
            originalTable.Columns.Add("DestinationAirport");
            originalTable.Columns.Add("DepartureDate");
            originalTable.Columns.Add("ArrivalDate");
            originalTable.Columns.Add("ActualDepartureDate");
            originalTable.Columns.Add("ActualArrivalDate");
            originalTable.Columns.Add("Plane");
            
            originalTable.Columns.Add("Cost");
            originalTable.Columns.Add("State");

            originalTable.Columns["OriginCountry"].ReadOnly = true;


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

                String actualDepartureDate = row["actualDepartureDate"].ToString();
                String actualArrivalDate = row["actualArrivalDate"].ToString();

                Guid planeID = Guid.Parse(row["planeID"].ToString());
                String planeName = reservationSystem.GetPlaneByID(planeID).name;

                String state = row["State"].ToString();

                String ID = row["ID"].ToString();

                String cost = row["Cost"].ToString();

                originalTable.Rows.Add(ID
                    , originCountry
                    , originCity
                    , originAirportName
                    , destinationCountry
                    , destinationCity
                    , destinationAirportName
                    , departureDate
                    , arrivalDate
                    , actualDepartureDate
                    , actualArrivalDate
                    , planeName
                    , cost
                    , state);

            }

        }

        private void DisplayFlights_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            PrepareSearch();
        }
        
        private void PrepareSearch()
        {
            queriedTable.Clear();
            String originCountry = OriginCountryTextBox.Text;
            String originCity = OriginCityTextBox.Text;
            String originAirportName = OriginAirportNameTextBox.Text;
            String destinationCountry = DestinationCountryTextBox.Text;
            String destinationCity = DestinationCityTextBox.Text;
            String destinationAirportName = DestinationAirportNameTextBox.Text;
            String departureDate = DepartureDatePicker.Text;
            String departureTime = DepartureTimePicker.Text;
            String arrivalDate = ArrivalDatePicker.Text;
            String arrivalTime = ArrivalTimePicker.Text;

            QueryInfo queryInfo = new QueryInfo(originCountry
                , originCity
                , originAirportName
                , destinationCountry
                , destinationCity
                , destinationAirportName
                , departureDate
                , departureTime
                , arrivalDate
                , arrivalTime);

            UpdateQueriedTable(queryInfo);
        }

        private void UpdateQueriedTable(QueryInfo queryInfo)
        {
            foreach(DataRow row in originalTable.Rows)
            {
                if (IsRowMatch(row,queryInfo))
                    queriedTable.Rows.Add(row.ItemArray);
            }

            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            UpdateStateColumn();
        }

        private bool IsRowMatch(DataRow row, QueryInfo queryInfo)
        {
            if(queryInfo.originCountry!="" 
                && !queryInfo.originCountry.Equals(row["OriginCountry"]))
                return false;

            if (queryInfo.originCity != ""
                && !queryInfo.originCity.Equals(row["OriginCity"]))
                return false;
            if (queryInfo.originAirportName != ""
                && !queryInfo.originAirportName.Equals(row["OriginAirportName"]))
                return false;
            if (queryInfo.destinationCoutry != ""
                && !queryInfo.destinationCoutry.Equals(row["DestinationCountry"]))
                return false;
            if (queryInfo.destinationCity != ""
                && !queryInfo.destinationCity.Equals(row["DestinationCity"]))
                return false;
            if (queryInfo.destinationAirportName != ""
                && !queryInfo.destinationAirportName.Equals(row["DestinationAirportName"]))
                return false;
            return true;
        }

        private void FlightGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.   
            //FlightGridView.Rows[e.RowIndex].ErrorText = String.Empty;

            DataGridViewRow row = FlightGridView.Rows[e.RowIndex];
            DataGridViewCellCollection cells= row.Cells;

            Guid flightID = Guid.Parse(cells["ID"].Value.ToString());

            string departureDateStr = cells["ActualDepartureDate"].Value.ToString();
            Nullable<DateTime> actualDepartureDate = null;
            if(departureDateStr!="")
                actualDepartureDate = DateTime.ParseExact(departureDateStr, "yyyy/mm/dd hh:mm:ss", CultureInfo.InvariantCulture);


            string actualArrivalDateStr = cells["ActualArrivalDate"].Value.ToString();
            Nullable<DateTime> actualArrivalDate = null;
            if (actualArrivalDateStr != "")
                actualArrivalDate = DateTime.ParseExact(actualArrivalDateStr, "yyyy/mm/dd hh:mm:ss", CultureInfo.InvariantCulture);

            FlightState state = PersianStringToFlightState(cells["StateComboBox"].Value.ToString());

            reservationSystem.UpdateFlight(flightID, state, actualArrivalDate, actualArrivalDate);

            InitialTables();

        }


        private FlightState PersianStringToFlightState(String stateStr)
        {
            switch (stateStr)
            {
                case "رسیده":
                    return FlightState.Arrived;
                    break;
                case "طبق قرار":
                    return FlightState.Scheduled;
                    break;
                case "با تاخیر":
                    return FlightState.Delayed;
                    break;
                case "در حال پرواز":
                    return FlightState.Enroute;
                    break;
            }
            
            return FlightState.None;
        }
        


        DataTable originalTable = null;
        DataTable queriedTable = null;
        DataGridViewComboBoxColumn stateComboBox = null;


        private void OriginAirportLabel_Click(object sender, EventArgs e)
        {

        }

        private void DepartureTimeLabel_Click(object sender, EventArgs e)
        {

        }

       

    }
}
