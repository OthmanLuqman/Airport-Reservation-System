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
        uint ID;

        Airplane airplane;
        
        Date departureDate;
        Date arrivalDate;

        Date actualDepartureDate;
        Date actualArrivalDate;

        Airport origin;
        Airport destination;

    }
}
