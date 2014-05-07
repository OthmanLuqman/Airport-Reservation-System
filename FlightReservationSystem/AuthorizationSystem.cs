using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    class AuthorizationSystem
    {
        public bool IsUserValid(String username, String password)
        {
            return DBFacade.IsUserValid(username, password);
        }
    }
}
