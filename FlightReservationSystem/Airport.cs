using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    public struct Location
    {
        public Location(String country, String city)
        {
            this.city = city;
            this.country = country;
        }

        public String city;
        public String country;
    };

    public class Airport
    {
        public Airport(Guid ID, String name , Location location)
        {
            Initial(ID, name, location);
        }

        public Airport(String name, Location location)
        {
            Initial(new Guid(), name, location);
        }

        private void Initial(Guid ID, String name , Location location)
        {
            this.ID = ID;
            this.name = name;
            this.location = location;
        }

        public void SetID(Guid ID)
        {
            this.ID = ID;
        }
        public Guid GetID()
        {
            return ID;
        }

        public Guid ID;
        public String name;
        public Location location;
        

    }
}
