using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    public class ReservationSystem
    {

        
        AuthorizationSystem authorizationSystem;
        public ReservationSystem()
        {
            authorizationSystem = new AuthorizationSystem();
        }
        public bool Login(String username, String password)
        {
            if (authorizationSystem.IsUserValid(username, password))
            {
                CreateAndSetSalesman(username);
                return true;
            }
            else
            {
                Console.WriteLine("User Or Name is not valid");
                return false;
            }
        }

        private void CreateAndSetSalesman(String username)
        {
            salesman = DBFacade.GetStaffByUsername(username);
        }

        public void ReserveFlight(Guid flightID, String fName, String lName, uint age, Gender gender, String nationalCode, List<uint> Seats)
        {
            Flight f = ServiceFactory.GetFlights().GetFlightByID(flightID);

            Passenger p = CreateAndInsertPassenger(fName, lName, age, gender, nationalCode);

            
           
            //TODO add flight 
        }

        private Passenger CreateAndInsertPassenger(String fName, String lName, uint age, Gender gender, String nationalCode)
        {
            Passenger passenger = new Passenger(fName, lName, age, gender, nationalCode);

            ServiceFactory.GetPassengers().AddPassenger(passenger);

            Guid passengerID = DBFacade.InsertPassengerAndReturnID(fName, lName, age, gender.ToString(), nationalCode);
            passenger.SetID(passengerID);
  
            return passenger;
        }

        private void CreateAndInsertReservation(Flight flight, Passenger passenger, Staff salesman, List<uint> seats)
        {
            //TODO: I must set time to time inserted in DB
            Reservation reservation = new Reservation(flight, passenger, salesman, seats,new DateTime());

            ServiceFactory.GetReserations().AddReservation(reservation);

            Guid reservationID = DBFacade.InsertReservationAndReturnID(flight.GetID(), passenger.GetID(), seats);
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

        public void AddFlight( Guid planeID, Guid originAirportID, Guid destinationAirportID, DateTime departureDate, DateTime arrivalDate)
        {

            Airport origin = ServiceFactory.GetAirports().GetAirportByID(originAirportID);
            Airport destination = ServiceFactory.GetAirports().GetAirportByID(destinationAirportID);

            Airplane plane = ServiceFactory.GetAirplanes().GetPlaneByID(planeID);

            Flight flight = new Flight(plane, origin, destination, departureDate, arrivalDate);

            ServiceFactory.GetFlights().AddFlight(flight);

            Guid flightID = DBFacade.InsertFlightAndReturnID(planeID, originAirportID, destinationAirportID, departureDate, arrivalDate);
            flight.SetID(flightID);
        }

        Salesman salesman;
    }




}
