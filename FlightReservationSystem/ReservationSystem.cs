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

        private void OpenMainPage()
        {
            new MainPage().Show();
        }

        public void ReserveFlight(uint flightID, String fName, String lName, uint age, Gender gender, String nationalCode)
        {
            Flight f = ServiceFactory.GetFlights().GetFlightByID(flightID);


            Passenger p = new Passenger()

           
        }

        Salesman salesman;
    }
}
