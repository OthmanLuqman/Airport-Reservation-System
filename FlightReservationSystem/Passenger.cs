using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Gender
{
    male, female
};

namespace FlightReservationSystem
{
    class Passenger : Person
    {
        uint age;
        Gender gender;
        String nationalCode;

    }
}
