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

    struct QueryInfo
    {
        public QueryInfo(String companyName)
        {
            this.companyName = companyName;
        }

        public String companyName;
    };
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
            PlanesGridView.Columns["CompanyName"].HeaderText= "نام شرکت";
            PlanesGridView.Columns["Capacity"].HeaderText = "ظرفیت";
            PlanesGridView.Columns["Name"].HeaderText = "نام هواپیما";
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            PrepareSearch();
        }

        private void PrepareSearch()
        {
            queriedTable.Clear();

            String companyName = CompanyNameTextBox.Text;

            QueryInfo queryInfo = new QueryInfo(companyName);

            UpdateQueriedTable(queryInfo);
        }

        private void UpdateQueriedTable(QueryInfo queryInfo)
        {
            foreach (DataRow row in originalTable.Rows)
            {
                if (IsRowMatched(row, queryInfo))
                    queriedTable.Rows.Add(row.ItemArray);
            }

           
        }



        private bool IsRowMatched(DataRow row, QueryInfo queryInfo)
        {
            if (queryInfo.companyName!= ""
                && !queryInfo.companyName.Equals(row["CompanyName"]))
                return false;

  
            return true;
        }

        private void CompanyNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
