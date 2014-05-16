using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FlightReservationSystem
{
    struct Date
    {
        Guid year;
        Guid month;
        Guid day;
        Guid hour;
        Guid seconds;
    };
    class Flight
    {

        public Flight(Guid ID, Airplane airplane, Airport origin, Airport destination, DateTime departureDate, DateTime arrivalDate, DateTime actualDepartureDate, DateTime actualArrivalDate)
        {
            Initial(ID, airplane, origin, destination, departureDate, arrivalDate, actualDepartureDate, actualArrivalDate);
        }

        public Flight(Airplane airplane, Airport origin, Airport destination, DateTime departureDate, DateTime arrivalDate)
        {
            Initial(new Guid(), airplane, origin, destination, departureDate, arrivalDate, new DateTime(), new DateTime());
        }

        private void Initial (Guid ID, Airplane airplane, Airport origin, Airport destination, DateTime departureDate, DateTime arrivalDate, DateTime actualDepartureDate, DateTime actualArrivalDate)
        {
            this.ID = ID;
            this.airplane = airplane;
            this.origin = origin;
            this.destination = destination;
            this.departureDate = departureDate;
            this.arrivalDate = arrivalDate;
            this.actualArrivalDate = actualArrivalDate;
            this.actualDepartureDate = actualDepartureDate;
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

        Airplane airplane;
        
        DateTime departureDate;
        DateTime arrivalDate;

        DateTime actualDepartureDate;
        DateTime actualArrivalDate;

        Airport origin;
        Airport destination;

    }
}
