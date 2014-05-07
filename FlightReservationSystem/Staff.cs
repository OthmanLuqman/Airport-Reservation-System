using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    public class Staff: Person
    {
        public Staff(uint ID, String firstName, String lastName) 
            : base(ID,firstName,lastName)
        {
            Console.WriteLine("Staff Info : {0} {1} {2}", ID, firstName, lastName);
        }
    }
}
