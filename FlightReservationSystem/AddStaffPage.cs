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
    public partial class AddStaffPage : Form
    {
        ReservationSystem reservationSystem;
        public AddStaffPage(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String username = UsernameTextBox.Text;
            String password = PasswordTextBox.Text;
            String fName = FirstNameTextBox.Text;
            String lName = LastNameTextBox.Text;
            Rank rank = Utilities.StringToRank(PersianRankToEnglish(RankComboBox.Text));

            reservationSystem.AddStaff(username, password, fName, lName, rank);
            this.Close();

        }

        private String PersianRankToEnglish(string rankStr)
        {
            Dictionary<String, String> convertor = new Dictionary<string, string>();
            convertor.Add("مدیر", "manager");
            convertor.Add("فروشنده", "salesman");
            convertor.Add("", "");
            return convertor[rankStr];
        }
    }
}
