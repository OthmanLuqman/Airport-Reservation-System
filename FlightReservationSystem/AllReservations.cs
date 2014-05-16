using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FlightReservationSystem
{
    class AllReservations
    {

        public AllReservations()
        {
            DataTable reservationTable = DBFacade.GetReservations();

            for (int i = 0; i < reservationTable.Rows.Count; i++)
            {
                Guid ID = Guid.Parse(reservationTable.Rows[i]["ID"].ToString());

                Guid flightID = Guid.Parse(reservationTable.Rows[i]["FlightID"].ToString());
                Flight flight = ServiceFactory.GetFlights().GetFlightByID(flightID);

                Guid passengerID = Guid.Parse(reservationTable.Rows[i]["PassengerID"].ToString());
                Passenger passenger = ServiceFactory.GetPassengers().GetPassengerByID(passengerID);

                Guid staffID = Guid.Parse(reservationTable.Rows[i]["StaffID"].ToString());
                Staff staff = ServiceFactory.GetStaffs().GetStaffByID(staffID);

                DateTime reservationTime = DateTime.Parse(reservationTable.Rows[i]["ReservationTime"].ToString());

                List<uint> seats = new List<uint>();

                reservations.Add(new Reservation(ID,flight,passenger,staff, seats,reservationTime));
            }
        }

        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        

        List<Reservation> reservations = new List<Reservation>();
    }

    
}
