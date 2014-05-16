using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    public class Manager: Staff 
    {
        public Manager(Guid ID , String fName, String lName)
            : base(ID, fName, lName )
        {

        }

        public Manager(String fName, String lName)
            : base(new Guid(), fName, lName )
        {

        }
    }
}
