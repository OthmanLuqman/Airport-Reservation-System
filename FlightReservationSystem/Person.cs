using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    public class Person
    {
        public Person(Guid ID, String firstName, String lastName)
        {
            this.ID = ID;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person( String firstName, String lastName)
        {
            this.ID = new Guid();
            this.firstName = firstName;
            this.lastName = lastName;
        }


        public Guid GetID()
        {
            return ID;
        }

        public void SetID(Guid ID)
        {
            this.ID = ID;
        }

        public Guid ID;
        public String firstName;
        public String lastName;
    }
}
