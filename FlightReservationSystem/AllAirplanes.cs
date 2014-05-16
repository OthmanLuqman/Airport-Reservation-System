using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    class AllAirplanes
    {
        public AllAirplanes()
        {
            DataTable planeTable = DBFacade.GetAirplanes();
            for (int i = 0; i < planeTable.Rows.Count; i++)
            {
                Guid ID = Guid.Parse(planeTable.Rows[i]["ID"].ToString());
                uint capacity = uint.Parse(planeTable.Rows[i]["capacity"].ToString());

                planes.Add(new Airplane(ID,capacity));
            }
        }

        public Airplane GetPlaneByID(Guid ID)
        {
            for (int i = 0; i < planes.Count; ++i)
            {
                if (planes[i].GetID() == ID)
                    return planes[i];
            }

            //TODO: throw exception
            return null;
        }

        List<Airplane> planes = new List<Airplane>();
    }

    
}
