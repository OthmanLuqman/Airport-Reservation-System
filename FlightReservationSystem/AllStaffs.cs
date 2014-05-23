using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FlightReservationSystem
{
    class AllStaffs
    {

        public AllStaffs()
        {
            staffTable = DBFacade.GetStaffs();
            for (int i = 0; i < staffTable.Rows.Count; i++)
            {
                Guid ID = Guid.Parse(staffTable.Rows[i]["ID"].ToString());
                String fName = staffTable.Rows[i]["FirstName"].ToString();
                String lName = staffTable.Rows[i]["LastName"].ToString();
                Rank rank = Utilities.StringToRank(staffTable.Rows[i]["Rank"].ToString());

                staffs.Add(Utilities.CreateStaff(rank, fName, lName,ID));
            }
        }

        public void AddStaff(Staff staff)
        {
            staffs.Add(staff);
        }

        public Staff GetStaffByID(Guid ID)
        {
            for(int i = 0 ; i < staffs.Count ; ++i)
            {
                if (staffs[i].GetID() == ID)
                    return staffs[i];
            }

            //TODO: return an exception
            return null;
        }

        public DataTable GetTable()
        {
            return staffTable;
        }

        DataTable staffTable;
        List<Staff> staffs = new List<Staff>();
    }
}
