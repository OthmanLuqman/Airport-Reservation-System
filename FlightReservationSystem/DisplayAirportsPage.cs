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
    

    public partial class DisplayAirportsPage : Form
    {
        struct QueryInfo
        {
            public QueryInfo(String name, String city, String country)
            {
                this.name = name;
                this.city = city;
                this.country = country;
            }
            
            public String name;
            public String city;
            public String country;

        };



        ReservationSystem reservationSystem;
        public DisplayAirportsPage(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;
            InitializeComponent();
            InitialTables();
        }

        public DisplayAirportsPage()
        {
            InitializeComponent();
        }

        private void InitialTables()
        {
            DataTable dt = reservationSystem.GetAirportsTable();

            InitialOriginalTable(dt);

            queriedTable = originalTable.Copy();
            AirportGridView.DataSource = queriedTable;
            AirportGridView.Columns["ID"].Visible = false;
        }

        private void InitialOriginalTable(DataTable dt)
        {
            originalTable = dt.Copy();
            
        }

        private void DisplayAirportsPage_Load(object sender, EventArgs e)
        {

        }

        

        private void SearchAirportButton_Click(object sender, EventArgs e)
        {
            PrepareSearch();
        }

        private void PrepareSearch()
        {
            queriedTable.Clear();

            String name = AirportNameTextBox.Text;
            String city = AirportCityTextBox.Text;
            String country = AirportCountryTextBox.Text;

            QueryInfo queryInfo = new QueryInfo(name, city, country);
            
            UpdateQueriedTable(queryInfo);
        }

        private void UpdateQueriedTable(QueryInfo queryInfo)
        {
            foreach (DataRow row in originalTable.Rows)
            {
                if (IsRowMatch(row, queryInfo))
                    queriedTable.Rows.Add(row.ItemArray);
            }
        }

        private bool IsRowMatch(DataRow row, QueryInfo queryInfo)
        {
            if (queryInfo.name != ""
                && !queryInfo.name.Equals(row["name"]))
                return false;
            if (queryInfo.city != ""
              && !queryInfo.city.Equals(row["city"]))
                return false;
            if (queryInfo.country != ""
             && !queryInfo.country.Equals(row["country"]))
                return false;  
            return true;
        }

        DataTable queriedTable;
        DataTable originalTable;
        
    }
}
