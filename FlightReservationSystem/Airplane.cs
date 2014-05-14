using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    class Airplane
    {
        public Airplane(uint ID, uint capacity)
        {
            this.ID = ID;
            this.capacity = capacity;
        }

        public uint GetID()
        {
            return ID;
        }
        uint ID; 
        uint capacity;
    }
}
