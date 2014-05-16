using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    class Reservation
    {
        public Reservation( Flight flight, Passenger passenger, Staff saleman, List<uint> seats, DateTime time)
        {
            Initial(new Guid(), flight, passenger, salesman, seats, time);
        }

        public Reservation(Guid ID,Flight flight, Passenger passenger, Staff saleman, List<uint> seats,DateTime time)
        {
            Initial(ID, flight, passenger, salesman, seats, time);
        }

        private void Initial(Guid ID,Flight flight, Passenger passenger, Staff salesman, List<uint> seats, DateTime time)
        {
            this.ID = ID;
            this.flight = flight;
            this.passenger = passenger;
            this.salesman = salesman;
            this.reservationDate = time;
            this.seats = seats; 
        }

        Guid ID;

        List<uint> seats;
        Flight flight;
        Passenger passenger;
        Staff salesman;

        DateTime reservationDate;
    }
}
