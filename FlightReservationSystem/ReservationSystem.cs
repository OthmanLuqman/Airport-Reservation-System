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
        public void Login(String username, String password)
        {
            if (authorizationSystem.IsUserValid(username, password))
                CreateAndSetSalesman(username);

            else
                Console.WriteLine("User Or Name is not valid");
        }

        private void CreateAndSetSalesman(String username)
        {

            salesman = DBFacade.GetStaffByUsername(username);
        }


        Salesman salesman;
    }
}
