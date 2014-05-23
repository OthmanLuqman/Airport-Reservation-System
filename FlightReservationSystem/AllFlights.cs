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
            flightTable = DBFacade.GetFlights();

            AllAirplanes allPlanes = ServiceFactory.GetAirplanes();
            AllAirports allAirports = ServiceFactory.GetAirports();

            for(int i = 0 ; i< flightTable.Rows.Count ; i++)
            {
                Guid ID = Guid.Parse(flightTable.Rows[i]["ID"].ToString());

                Guid planeID = Guid.Parse(flightTable.Rows[i]["planeID"].ToString());
                Airplane airplane = allPlanes.GetPlaneByID(planeID);

                Guid originID = Guid.Parse(flightTable.Rows[i]["originAirportID"].ToString());
                Airport origin = allAirports.GetAirportByID(originID);

                Guid destinationID = Guid.Parse(flightTable.Rows[i]["destinationAirportID"].ToString());
                Airport destination = allAirports.GetAirportByID(destinationID);

                DateTime arrivalDate = DateTime.Parse(flightTable.Rows[i]["arrivalDate"].ToString());
                DateTime departureDate = DateTime.Parse(flightTable.Rows[i]["departureDate"].ToString());

                String actualArrivalDateStr = flightTable.Rows[i]["actualArrivalDate"].ToString();
                Nullable<DateTime> actualArrivalDate= null;
                if(!actualArrivalDateStr.Equals(""))
                    actualArrivalDate = DateTime.Parse(actualArrivalDateStr);



                String actualDepartureDateStr = flightTable.Rows[i]["actualDepartureDate"].ToString();
                Nullable<DateTime> actualDepartureDate = null;
                if (!actualDepartureDateStr.Equals(""))
                    actualDepartureDate = DateTime.Parse(actualDepartureDateStr);


                String flightStateStr = flightTable.Rows[i]["State"].ToString();
                FlightState flightState = Utilities.StringToFlightState(flightStateStr);

                uint cost = uint.Parse(flightTable.Rows[i]["Cost"].ToString());

                flights.Add(new Flight(ID, airplane, origin, destination, departureDate, arrivalDate, actualDepartureDate, actualArrivalDate, flightState, cost));
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

        public DataTable GetTable()
        {
            return flightTable;
        }

        DataTable flightTable = null;

        List<Flight> flights = new List<Flight>();
    }
}
