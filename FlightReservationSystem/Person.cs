using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    public class Person
    {
        public Person(uint ID, String firstName, String lastName)
        {
            this.ID = ID;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        uint ID;
        String firstName;
        String lastName;
    }
}
