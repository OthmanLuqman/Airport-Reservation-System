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
            UpdateTable();
        }

        public void UpdateTable()
        {
            reservationTable.Clear();
            reservationTable = DBFacade.GetReservations();

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

                String cancelTimeStr = reservationTable.Rows[i]["cancelTime"].ToString();
                Nullable<DateTime> cancelTime = null;
                if (!cancelTimeStr.Equals(""))
                    cancelTime = DateTime.Parse(cancelTimeStr);

                uint seatNumber = uint.Parse(reservationTable.Rows[i]["SeatNumber"].ToString());

                ReservationState state = Utilities.StringToReservationState(reservationTable.Rows[i]["State"].ToString());


                reservations.Add(new Reservation(ID, flight, passenger, staff, seatNumber, reservationTime, state, cancelTime));
            }
        }
        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        public void RemoveReservationByID(Guid ID)
        {
            Reservation res = GetReservationByID(ID);
            reservations.Remove(res);
        }

        public Reservation GetReservationByID(Guid ID)
        {
            for(int i  = 0 ; i< reservations.Count; ++i)
            {
                if (reservations[i].GetID() == ID)
                    return reservations[i];
            }

            //TODO: throw exception
            return null;
        }

        public DataTable GetTable()
        {
            return reservationTable;
        }


        DataTable reservationTable = new DataTable();
        List<Reservation> reservations = new List<Reservation>();
    }

    
}
