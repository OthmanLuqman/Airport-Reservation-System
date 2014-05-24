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
    public partial class DisplayStaffsPage : Form
    {
        struct QueryInfo
        {
            public QueryInfo(String firstName, String lastName, String rank)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.rank = rank;
            }

            public String firstName;
            public String lastName;
            public String rank;

        };

        ReservationSystem reservationSystem;
        public DisplayStaffsPage(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;
            InitializeComponent();
            InitialTables();
        }

        private void InitialTables()
        {
            DataTable dt = reservationSystem.GetStaffsTable();

            InitialOriginalTable(dt);

            queriedTable = originalTable.Copy();
            StaffGridView.DataSource = queriedTable;
            StaffGridView.Columns["Rank"].HeaderText = "سمت";
            StaffGridView.Columns["FirstName"].HeaderText = "نام ";
            StaffGridView.Columns["LastName"].HeaderText = "نام خانوادگی";
        }

        void InitialOriginalTable(DataTable dt)
        {
            originalTable = dt.Copy();
            originalTable.Columns.Remove("ID");
        }

        private void PrepareSearch()
        {
            queriedTable.Clear();

            String rank = PersionRankToEnglishRank(RankComboBox.Text).ToLower();
            String firstName = FirstNameTextBox.Text.ToLower();
            String lastName = LastNameTextBox.Text.ToLower();

            QueryInfo queryInfo = new QueryInfo(firstName, lastName, rank);

            UpdateQueriedTable(queryInfo);
        }

        private String PersionRankToEnglishRank(string persionRank)
        {
            if (persionRank == "")
                return "";
            Dictionary<String, String> convertor = new Dictionary<String, String>();
            convertor.Add("مدیر", "Manager");
            convertor.Add("فروشنده", "Salesman");
            return convertor[persionRank];
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
            if (queryInfo.firstName != ""
                && !queryInfo.firstName.Equals(row["FirstName"].ToString().ToLower()))
                return false;
            if (queryInfo.lastName != ""
              && !queryInfo.lastName.Equals(row["LastName"].ToString().ToLower()))
                return false;
            if (queryInfo.rank != ""
             && !queryInfo.rank.Equals(row["Rank"].ToString().ToLower()))
                return false;
            return true;
        }


        DataTable queriedTable;
        DataTable originalTable;

        private void DisplayStaffsPage_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            PrepareSearch();
        }


    }
}
