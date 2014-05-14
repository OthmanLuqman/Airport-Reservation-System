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

        String city;
        String country;
    };

    class Airport
    {
        public Airport(uint ID, String name , Location location)
        {
            this.ID = ID;
            this.name = name;
            this.location = location;
        }
        public uint GetID()
        {
            return ID;
        }

        uint ID;
        String name;
        Location location;
        

    }
}
