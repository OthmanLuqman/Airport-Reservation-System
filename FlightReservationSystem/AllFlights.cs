using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace FlightReservationSystem
{
    class AllFlights
    {
        public AllFlights()
        {
            DataTable flightTable = DBFacade.GetFlights();

            AllAirplanes allPlanes = ServiceFactory.GetAirplanes();
            AllAirports allAirports = ServiceFactory.GetAirports();

            for(int i = 0 ; i< flightTable.Rows.Count ; i++)
            {
                Guid ID = Guid.Parse(flightTable.Rows[i]["ID"].ToString());

                Guid planeID = Guid.Parse(flightTable.Rows[i]["planeID"].ToString());
                Airplane airplane = allPlanes.GetPlaneByID(planeID);

                Guid originID = Guid.Parse(flightTable.Rows[i]["originAirportID"].ToString());
                Airport origin = allAirports.GetAirportByID(originID);

                Guid destinationID = Guid.Parse(flightTable.Rows[i]["originAirportID"].ToString());
                Airport destination = allAirports.GetAirportByID(destinationID);

                DateTime arrivalDate = DateTime.Parse(flightTable.Rows[i]["arrivalDate"].ToString());
                DateTime departureDate = DateTime.Parse(flightTable.Rows[i]["departureDate"].ToString());
                DateTime actualArrivalDate = DateTime.Parse(flightTable.Rows[i]["actualArrivalDate"].ToString());
                DateTime actualDepartureDate = DateTime.Parse(flightTable.Rows[i]["actualDepartureDate"].ToString());

                flights.Add(new Flight(ID, airplane, origin, destination, departureDate, arrivalDate, actualDepartureDate, actualArrivalDate));
            }
        }

        public Flight GetFlightByID(Guid ID)
        {
            for(int i = 0 ; i < flights.Count ; ++i)
            {
                if (flights[i].GetID() == ID)
                    return flights[i];
            }

            //TODO: throw exception
            return null;
        }

        public void AddFlight(Flight flight)
        {
            flights.Add(flight);
        }

        List<Flight> flights = new List<Flight>();
    }
}
