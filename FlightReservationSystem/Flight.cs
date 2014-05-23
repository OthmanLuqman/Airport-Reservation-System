using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FlightReservationSystem
{

    public enum FlightState
    {
        None, Arrived, Scheduled, Enroute, Delayed    
    };
    public class Flight
    {

        public Flight(Guid ID, Airplane airplane, Airport origin, Airport destination, DateTime departureDate, DateTime arrivalDate, Nullable<DateTime> actualDepartureDate, Nullable<DateTime> actualArrivalDate, FlightState state, uint cost)
        {
            Initial(ID, airplane, origin, destination, departureDate, arrivalDate, actualDepartureDate, actualArrivalDate, state, cost);
        }

        public Flight(Airplane airplane, Airport origin, Airport destination, DateTime departureDate, DateTime arrivalDate, uint cost)
        {
            Initial(new Guid(), airplane, origin, destination, departureDate, arrivalDate, null, null, FlightState.Scheduled, cost);
        }

        private void Initial(Guid ID, Airplane airplane, Airport origin, Airport destination, DateTime departureDate, DateTime arrivalDate, Nullable<DateTime> actualDepartureDate, Nullable<DateTime> actualArrivalDate, FlightState state, uint cost)
        {
            this.ID = ID;
            this.airplane = airplane;
            this.origin = origin;
            this.destination = destination;
            this.departureDate = departureDate;
            this.arrivalDate = arrivalDate;
            this.actualArrivalDate = actualArrivalDate;
            this.actualDepartureDate = actualDepartureDate;
            this.flightState= state;
            this.cost = cost;
        }

        
        public Guid GetID()
        {
            return ID;
        }

        public void SetID(Guid ID)
        {
            this.ID = ID;
        }

        public Guid ID;

        public Airplane airplane;

        public DateTime departureDate;
        public DateTime arrivalDate;

        public Nullable<DateTime> actualDepartureDate;
        public Nullable<DateTime> actualArrivalDate;

        public Airport origin;
        public Airport destination;

        public FlightState flightState;

        public uint cost = 0;
    }
}
