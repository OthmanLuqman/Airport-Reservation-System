using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    public class Salesman : Staff
    {
        public Salesman(Guid ID, String firstName, String lastName)
            : base(ID, firstName, lastName)
        {

        }

        public Salesman(String firstName, String lastName)
            : base(new Guid(), firstName, lastName)
        {

        }
    }
}
