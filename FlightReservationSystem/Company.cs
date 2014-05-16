using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    class Company
    {
        public Company(Guid ID, String name)
        {
            this.ID = ID;
            this.name = name;
        }

        public Company(String name)
        {
            this.ID = new Guid();
            this.name = name;
        }

        public void SetID( Guid ID)
        {
            this.ID = ID;
        }

        Guid ID;

        String name;

        List<Airplane> airplanes;
    }
}
