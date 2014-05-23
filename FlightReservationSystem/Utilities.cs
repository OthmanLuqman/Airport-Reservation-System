using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data;
using System.ComponentModel;


namespace FlightReservationSystem
{
    static class Utilities
    {
        static public Gender StringToGender(string genderStr)
        {
            switch(genderStr)
            {
                case "male":
                    return Gender.male;
                case "female":
                    return Gender.female;
                default:
                    Debug.Assert(false);
                    break;
            }
            return Gender.male;
        }

        static public Rank GetStaffRank(Staff staff)
        {
            if (staff is Manager)
                return Rank.Manager;
            else if (staff is Salesman)
                return Rank.Salesman;

            return Rank.None;
        }
        static public Rank StringToRank(string rankStr)
        {
            rankStr = rankStr.ToLower();
            switch (rankStr)
            {
                case "manager":
                    return Rank.Manager;
                case "salesman":
                    return Rank.Salesman;
                default:
                    Debug.Assert(false,"Invalid String for Rank : " + rankStr);
                    break;
            }
            return Rank.Salesman;
        }

        static public FlightState StringToFlightState(string stateStr)
        {
            stateStr = stateStr.ToLower();
            switch (stateStr)
            {
                case "scheduled":
                    return FlightState.Scheduled;
                case "arrived":
                    return FlightState.Arrived;
                case "enroute":
                    return FlightState.Enroute;
                case "delayed":
                    return FlightState.Delayed;
                default:
                    Debug.Assert(false, "Invalid String for FlightState");
                    break;
            }
            return FlightState.None;
        }

        static public ReservationState StringToReservationState(string stateStr)
        {
            stateStr = stateStr.ToLower();
            switch (stateStr)
            {
                case "reserved":
                    return ReservationState.Resereved;
                case "canceled":
                    return ReservationState.Canceled;
                default:
                    Debug.Assert(false, "Invalid String for Reservation State : " + stateStr);
                    break;
            }
            return ReservationState.None;
        }

        static public Staff CreateStaff(Rank rank, String fName, String lName, Guid ID = new Guid())
        {
            switch(rank)
            {
                case Rank.Manager:
                    return new Manager(ID, fName,lName);
                case Rank.Salesman:
                    return new Salesman(ID,fName, lName);
                default:
                    Debug.Assert(false,"Rank is Not Valid");
                    break;
            }

            return null;
        }

       static public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
    }

}
