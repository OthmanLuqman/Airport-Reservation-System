using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FlightReservationSystem
{
    public enum Gender
    {
        male, female
    };



    class Passenger : Person
    {
        public Passenger(Guid ID, String firstName, String lastName, uint age, Gender gender, String nationalCode) 
            : base(ID,firstName,lastName)
        {
            this.age = age;
            this.gender = gender;
            this.nationalCode = nationalCode;
            Console.WriteLine("Passenger Info : {0} {1} {2} {3} {4}", ID, firstName, lastName, age, nationalCode);
        }

        public Passenger( String firstName, String lastName, uint age, Gender gender, String nationalCode)
            : base(firstName, lastName)
        {
            this.age = age;
            this.gender = gender;
            this.nationalCode = nationalCode;
            Console.WriteLine("Passenger Info : {0} {1} {2} {3}", firstName, lastName, age, nationalCode);
        }


        uint age;
        Gender gender;
        String nationalCode;

    }
}
