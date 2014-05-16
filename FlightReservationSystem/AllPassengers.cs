using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FlightReservationSystem
{
    class AllPassengers
    {
        public AllPassengers()
        {

        }

        public void Update()
        {
            passengers.Clear();
            DataTable passengerTable = DBFacade.GetPassengers();
            for (int i = 0; i < passengerTable.Rows.Count; i++)
            {
                Guid ID = Guid.Parse(passengerTable.Rows[i]["ID"].ToString());
                string fName = passengerTable.Rows[i]["FirstName"].ToString();
                string lName = passengerTable.Rows[i]["LastName"].ToString();
                uint age = uint.Parse(passengerTable.Rows[i]["Age"].ToString());
                Gender gender = Utilities.StringToGender(passengerTable.Rows[i]["Gender"].ToString());
                string nationalCode = passengerTable.Rows[i]["NationalCode"].ToString();

                passengers.Add(new Passenger(ID, fName, lName, age, gender, nationalCode));
            }
        }

        public Passenger GetPassengerByID(Guid ID)
        {
            for (int i = 0; i < passengers.Count; ++i)
            {
                if (passengers[i].GetID() == ID)
                    return passengers[i];
            }

            //TODO: throw exception
            return null;
        }

        public void AddPassenger(Passenger passenger)
        {
            passengers.Add(passenger);
        }

        List<Passenger> passengers = new List<Passenger>();
    }
}
