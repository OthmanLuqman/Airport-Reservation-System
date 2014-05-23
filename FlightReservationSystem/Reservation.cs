using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{

    enum ReservationState
    {
        None, Resereved, Canceled
    };
    class Reservation
    {
        public Reservation(Flight flight, Passenger passenger, Staff saleman, uint seatNumber, DateTime time, ReservationState state, Nullable<DateTime> cancelTime)
        {
            Initial(new Guid(), flight, passenger, salesman, seatNumber, time,state, cancelTime);
        }

        public Reservation(Guid ID, Flight flight, Passenger passenger, Staff saleman, uint seatNumber, DateTime time, ReservationState state, Nullable<DateTime> cancelTime)
        {
            Initial(ID, flight, passenger, salesman, seatNumber, time, state, cancelTime );
        }

        private void Initial(Guid ID, Flight flight, Passenger passenger, Staff salesman, uint seatNumber, DateTime time, ReservationState state, Nullable<DateTime> cancelTime)
        {
            this.ID = ID;
            this.flight = flight;
            this.passenger = passenger;
            this.salesman = salesman;
            this.reservationDate = time;
            this.seatNumber = seatNumber;
            this.reservationState = state;
            this.cancelTime = cancelTime;
        }

        public Guid GetID()
        {
            return ID;
        }

        public void SetID(Guid ID)
        {
            this.ID = ID;
        }

        Guid ID;

        ReservationState reservationState;

        uint seatNumber;
        Flight flight;
        Passenger passenger;
        Staff salesman;

        DateTime reservationDate;

        Nullable<DateTime> cancelTime;
    }
}
