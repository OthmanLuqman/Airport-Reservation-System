using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    public class Airplane
    {
        public Airplane(Guid ID, String name,uint capacity)
        {
            Initial(ID, name, capacity);
        }

        public Airplane( String name, uint capacity)
        {
            Initial(new Guid(), name, capacity);
        }

        private void Initial(Guid ID, String name, uint capacity)
        {
            this.ID = ID;
            this.capacity = capacity;
            this.name = name;
        }

        

        public Guid GetID()
        {
            return ID;
        }

        public Guid ID; 
        public uint capacity;
        public String name;
    }
}
