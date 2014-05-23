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
    public partial class DisplayReservationsPage : Form
    {

        ReservationSystem reservationSystem;
        public DisplayReservationsPage()
        {
            InitializeComponent();
        }
        public DisplayReservationsPage(ReservationSystem reservationSystem)
        {
            this.reservationSystem = reservationSystem;
            InitializeComponent();
            InitialTables();
        }



        private void InitialTables()
        {
            DataTable dt = reservationSystem.GetReservationsTable();

            InitialOriginTable(dt);
            
            queriedTable = originalTable.Copy();

            ReservationGridView.DataSource = queriedTable;
            ReservationGridView.Columns["ID"].Visible = false;
            ReservationGridView.Columns["FlightID"].Visible = false;
            ReservationGridView.Columns["PassengerID"].Visible = false;
            ReservationGridView.Columns["StaffID"].Visible = false;
       
        }

        private void InitialOriginTable(DataTable dt)
        {
            originalTable = dt.Copy();

            originalTable.Columns.Add("PassengerName");
            originalTable.Columns["PassengerName"].SetOrdinal(0);

            originalTable.Columns.Add("FlightInfo");
            originalTable.Columns["FlightInfo"].SetOrdinal(1);

            originalTable.Columns.Add("StaffName");
            //originalTable.Columns["StaffName"].SetOrdinal(2);


            foreach( DataRow row in originalTable.Rows)
            {
                Guid passengerID = Guid.Parse(row["PassengerID"].ToString());
                Passenger passenger = reservationSystem.GetPassengerByID(passengerID);
                string passengerName = passenger.firstName + " " + passenger.lastName;
                row["PassengerName"] = passengerName;

                Guid staffID = Guid.Parse(row["StaffID"].ToString());
                Staff staff = reservationSystem.GetStaffByID(staffID);
                string staffName = staff.firstName + " " + staff.lastName;
                row["StaffName"] = staffName;

                Guid flightID = Guid.Parse(row["FlightID"].ToString());
                Flight flight = reservationSystem.GetFlightByID(flightID);
                string flightInfo = flight.origin.name + " - " + flight.destination.name;
                row["FlightInfo"] = flightInfo;
            }

        }

        DataTable originalTable = null;
        DataTable queriedTable = null;
    }
}
