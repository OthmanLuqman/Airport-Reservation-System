using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    class Airplane
    {
        public Airplane(Guid ID, uint capacity)
        {
            this.ID = ID;
            this.capacity = capacity;
        }

        public Guid GetID()
        {
            return ID;
        }
        Guid ID; 
        uint capacity;
    }
}
