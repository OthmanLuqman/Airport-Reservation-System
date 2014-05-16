using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    static class ServiceFactory
    {
        public static AllFlights GetFlights()
        {
            if (allFlights == null)
                allFlights = new AllFlights();
            return allFlights;
        }

        public static AllAirplanes GetAirplanes()
        {
            if (allAirPlanes == null)
                allAirPlanes = new AllAirplanes();
            return allAirPlanes;
        }

        public static AllAirports GetAirports()
        {
            if (allAirports == null)
                allAirports = new AllAirports();
            return allAirports;
        }

        public static AllPassengers GetPassengers()
        {
            if (allPassengers == null)
                allPassengers = new AllPassengers();
            allPassengers.Update();
            return allPassengers;
        }

        public static AllCompanies GetCompanies()
        {
            if (allCompanies == null)
                allCompanies = new AllCompanies();
            allCompanies.Update();
            return allCompanies;
        }

        public static AllStaffs GetStaffs()
        {
            if (allStaffs == null)
                allStaffs = new AllStaffs();
            return allStaffs;

        }

        public static AllReservations GetReserations()
        {
            if (allReservations == null)
                allReservations = new AllReservations();
            return allReservations;

        }

        static AllFlights allFlights = null;
        static AllAirplanes allAirPlanes = null;
        static AllAirports allAirports = null;
        static AllPassengers allPassengers = null;
        static AllCompanies allCompanies = null;
        static AllStaffs allStaffs = null;
        static AllReservations allReservations = null;
    }
}
