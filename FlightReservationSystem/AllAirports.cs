using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FlightReservationSystem
{
    class AllAirports
    {
        public AllAirports()
        {
            airpotTable = DBFacade.GetAirports();
            for (int i = 0; i < airpotTable.Rows.Count; i++)
            {
                Guid ID = Guid.Parse(airpotTable.Rows[i]["ID"].ToString());

                String name = airpotTable.Rows[i]["name"].ToString();

                String country = airpotTable.Rows[i]["country"].ToString();
                String city = airpotTable.Rows[i]["city"].ToString();
                Location location= new Location(country,city);

                airports.Add(new Airport(ID,name,location));
            }
        }

        public Airport GetAirportByID(Guid ID)
        {
            for (int i = 0; i < airports.Count; ++i)
            {
                if (airports[i].GetID() == ID)
                    return airports[i];
            }

            //TODO: throw exception
            return null;
        }

        public void AddAirport(Airport airport)
        {
            airports.Add(airport);
        }

        public DataTable GetTable()
        {
            return airpotTable;
        }

        DataTable airpotTable;
        List<Airport> airports = new List<Airport>();
     }


}
