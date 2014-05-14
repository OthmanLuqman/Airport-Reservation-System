using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FlightReservationSystem
{
    struct Date
    {
        uint year;
        uint month;
        uint day;
        uint hour;
        uint seconds;
    };
    class Flight
    {

        public Flight(uint ID, Airplane airplane, Airport origin, Airport destination, DateTime departureDate, DateTime arrivalDate, DateTime actualDepartureDate, DateTime actualArrivalDate)
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

        
        public uint GetID()
        {
            return ID;
        }

        uint ID;

        Airplane airplane;
        
        DateTime departureDate;
        DateTime arrivalDate;

        DateTime actualDepartureDate;
        DateTime actualArrivalDate;

        Airport origin;
        Airport destination;

    }
}
