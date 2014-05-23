using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FlightReservationSystem
{
    public class ReservationSystem
    {

        
        AuthorizationSystem authorizationSystem;
        public ReservationSystem()
        {
            authorizationSystem = new AuthorizationSystem();
        }
        public Rank Login(String username, String password)
        {
            if (authorizationSystem.IsUserValid(username, password))
            {
                CreateAndSetStaff(username);
                return Utilities.GetStaffRank(currentStaff);
            }
            else
            {
                Console.WriteLine("User Or Name is not valid");
                return Rank.None;
            }
        }

        private void CreateAndSetStaff(String username)
        {
            currentStaff = DBFacade.GetStaffByUsername(username);
        }

        public void CancelReservation(Guid reservationID)
        {
            //ServiceFactory.GetReserations().RemoveReservationByID(reservationID);

            DBFacade.CancelReservation(reservationID);
        }

        public void AddReservation(Guid flightID, String fName, String lName, uint age, Gender gender, String nationalCode, uint seatNumber)
        {
            Flight f = ServiceFactory.GetFlights().GetFlightByID(flightID);

            //TO it in try catch block

            Passenger p = CreateAndInsertPassenger(fName, lName, age, gender, nationalCode);

            CreateAndInsertReservation(f, p, currentStaff, seatNumber);
        }

        private Passenger CreateAndInsertPassenger(String fName, String lName, uint age, Gender gender, String nationalCode)
        {
            Passenger passenger = new Passenger(fName, lName, age, gender, nationalCode);

            ServiceFactory.GetPassengers().AddPassenger(passenger);

            Guid passengerID = DBFacade.InsertPassengerAndReturnID(fName, lName, age, gender.ToString(), nationalCode);
            passenger.SetID(passengerID);
  
            return passenger;
        }

        private void CreateAndInsertReservation(Flight flight, Passenger passenger, Staff salesman, uint seatNumber)
        {
            //TODO: I must set time to time inserted in DB
            Reservation reservation = new Reservation(flight, passenger, salesman, seatNumber,new DateTime(),ReservationState.Resereved, null);

            ServiceFactory.GetReserations().AddReservation(reservation);

            Guid reservationID = DBFacade.InsertReservationAndReturnID(flight.GetID(), passenger.GetID(), currentStaff.GetID(), seatNumber);

            reservation.SetID(reservationID);
        }

        public void AddCompany(String name)
        {

            Company company = new Company(name);

            ServiceFactory.GetCompanies().AddCompany(company);

            Guid companyID = DBFacade.InsertCompanyAndReturnID(name);
            company.SetID(companyID);
        }

        public void AddStaff(String username, String password,String fName, String lName, Rank rank)
        {
            Staff staff = Utilities.CreateStaff(rank,fName,lName);

            ServiceFactory.GetStaffs().AddStaff(staff);

            Guid staffID = DBFacade.InsertNewUserAndReturnStaffID(username, password, fName, lName, rank.ToString());
            staff.SetID(staffID);

        }

        public void AddAirport(String name, Location location)
        {
            Airport airport = new Airport(name, location);

            ServiceFactory.GetAirports().AddAirport(airport);

            Guid airportID = DBFacade.InsertAirportAndReturnID(name, location);
            airport.SetID(airportID);
        }

        public void AddAirplane(String name, Guid companyID, uint capacity)
        {
            Airplane airplane = new Airplane(name, capacity);
            ServiceFactory.GetAirplanes().AddAirplane(airplane);

            Guid airplaneID = DBFacade.InsertAirplaneAndReturnID(name, companyID, capacity);
            airplane.ID = airplaneID;
        }

        public void AddFlight( Guid planeID, Guid originAirportID, Guid destinationAirportID, DateTime departureDate, DateTime arrivalDate, uint cost)
        {

            Airport origin = ServiceFactory.GetAirports().GetAirportByID(originAirportID);
            Airport destination = ServiceFactory.GetAirports().GetAirportByID(destinationAirportID);

            Airplane plane = ServiceFactory.GetAirplanes().GetPlaneByID(planeID);

            Flight flight = new Flight(plane, origin, destination, departureDate, arrivalDate,cost);

            ServiceFactory.GetFlights().AddFlight(flight);

            Guid flightID = DBFacade.InsertFlightAndReturnID(planeID, originAirportID, destinationAirportID, departureDate, arrivalDate, cost);
            flight.SetID(flightID);
        }

        public void UpdateFlight(Guid flightID, FlightState newState, Nullable<DateTime> newActualDepartureDate, Nullable<DateTime> newActualArrivalDate)
        {
            Flight f = ServiceFactory.GetFlights().GetFlightByID(flightID);
            f.flightState = newState;
            f.actualArrivalDate = newActualArrivalDate;
            f.actualDepartureDate = newActualDepartureDate;

            DBFacade.UpdateFlight(flightID, newState.ToString(), newActualDepartureDate, newActualArrivalDate);
        }
        public DataTable GetFlightsTable()
        {
            return ServiceFactory.GetFlights().GetTable();
        }

        public DataTable GetPassengersTable()
        {
            return ServiceFactory.GetPassengers().GetTable();
        }

        public DataTable GetCompaniesTable()
        {
            return ServiceFactory.GetCompanies().GetTable();
        }

        public DataTable GetAirportsTable()
        {
            return ServiceFactory.GetAirports().GetTable();
        }

        public DataTable GetReservationsTable()
        {
            return ServiceFactory.GetReserations().GetTable();
        }

        public DataTable GetStaffsTable()
        {
            return ServiceFactory.GetStaffs().GetTable();
        }

        public DataTable GetAirplanesTable()
        {
            return ServiceFactory.GetAirplanes().GetTable();
        }

        public Airport GetAirportByID(Guid ID)
        {
            return ServiceFactory.GetAirports().GetAirportByID(ID);
        }

        public Airplane GetPlaneByID(Guid ID)
        {
            return ServiceFactory.GetAirplanes().GetPlaneByID(ID);
        }

        public Passenger GetPassengerByID(Guid ID)
        {
            return ServiceFactory.GetPassengers().GetPassengerByID(ID);
        }

        public Staff GetStaffByID(Guid ID)
        {
            return ServiceFactory.GetStaffs().GetStaffByID(ID);
        }

        public Flight GetFlightByID(Guid ID)
        {
            return ServiceFactory.GetFlights().GetFlightByID(ID);
        }

        public Company GetCompanyByID(Guid ID)
        {
            return ServiceFactory.GetCompanies().GetCopmanyByID(ID);
        }

        public void UpdateTables()
        {

        }

        Staff currentStaff;
    }
}
