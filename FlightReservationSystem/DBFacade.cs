using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FlightReservationSystem
{
    static public class DBFacade
    {
        static SqlConnection connection;

        static DBFacade()
        {
            connection = new SqlConnection(@"Data Source=ARMAN\ARMANSQLSERVER;Initial Catalog=FlightReservationDataBase;Integrated Security=True");
        }
        static public bool IsUserValid(String username, String password)
        {
            return GetUser(username, password).Rows.Count != 0;
        }

        static public Staff GetStaffByUsername(String username)
        {
            SqlCommand cmd = new SqlCommand("GetStaffinfo", connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = SqlSelect(cmd);

            Console.WriteLine(dt);

            Rank rank = Utilities.StringToRank(dt.Rows[0]["Rank"].ToString());
            String fName = dt.Rows[0]["FirstName"].ToString();
            String lName = dt.Rows[0]["LastName"].ToString();
            Guid ID = Guid.Parse(dt.Rows[0]["ID"].ToString());

            return Utilities.CreateStaff(rank, fName, lName, ID);
            
        }

        static private DataTable GetUser(String username, String password)
        {
            SqlCommand cmd = new SqlCommand("UserSelection", connection);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            cmd.CommandType = CommandType.StoredProcedure;
            return SqlSelect(cmd);
        }

        static public DataTable GetFlights()
        {
            SqlCommand cmd = new SqlCommand("GetFlights", connection);

            cmd.CommandType = CommandType.StoredProcedure;

            return SqlSelect(cmd);
        }

        static public DataTable GetReservations()
        {
            SqlCommand cmd = new SqlCommand("GetReservations", connection);

            cmd.CommandType = CommandType.StoredProcedure;

            return SqlSelect(cmd);
        }

        static public DataTable GetAirports()
        {
            SqlCommand cmd = new SqlCommand("GetAirports", connection);

            cmd.CommandType = CommandType.StoredProcedure;

            return SqlSelect(cmd);
        }

        static public DataTable GetAirplanes()
        {
            SqlCommand cmd = new SqlCommand("GetPlanes", connection);

            cmd.CommandType = CommandType.StoredProcedure;

            return SqlSelect(cmd);
        }


        static public DataTable GetStaffs()
        {
            //TODO: Change procedure to "GetStaffs"
            SqlCommand cmd = new SqlCommand("GetStaff", connection);

            cmd.CommandType = CommandType.StoredProcedure;

            return SqlSelect(cmd);
        }

        static public DataTable GetPassengers()
        {
            SqlCommand cmd = new SqlCommand("GetPassengers", connection);

            cmd.CommandType = CommandType.StoredProcedure;

            return SqlSelect(cmd);
        }

        static public DataTable GetCompanies()
        {
            SqlCommand cmd = new SqlCommand("GetCompanies", connection);

            cmd.CommandType = CommandType.StoredProcedure;

            return SqlSelect(cmd);
        }

        static public Guid InsertPassengerAndReturnID(String fName, String lName, uint age, String gender, String nationalCode)
        {
            SqlCommand cmd = new SqlCommand("InsertPassanger", connection);

            cmd.Parameters.AddWithValue("@FirstName", fName);
            cmd.Parameters.AddWithValue("@LastName", lName);
            cmd.Parameters.AddWithValue("@Age", (int)age);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@NationalCode", nationalCode);

            cmd.CommandType = CommandType.StoredProcedure;

            return Guid.Parse(SqlSelect(cmd).Rows[0]["ID"].ToString());
        }

        static public Guid InsertFlightAndReturnID(Guid planeID, Guid originAirportID, Guid destinationAirportID, DateTime departureDate, DateTime arrivalDate, uint cost)
        {
            SqlCommand cmd = new SqlCommand("InsertFlight", connection);

            cmd.Parameters.AddWithValue("@PlaneID", planeID);
            cmd.Parameters.AddWithValue("@OriginAirportID", originAirportID);
            cmd.Parameters.AddWithValue("@DestinationAirportID", destinationAirportID);
            cmd.Parameters.AddWithValue("@DepartureDate", departureDate);
            cmd.Parameters.AddWithValue("@ArrivalDate", arrivalDate);
            cmd.Parameters.AddWithValue("@Cost", (int)cost);

            cmd.CommandType = CommandType.StoredProcedure;

            return Guid.Parse(SqlSelect(cmd).Rows[0]["ID"].ToString());
        }

        static public Guid InsertAirportAndReturnID(String name, Location location)
        {
            SqlCommand cmd = new SqlCommand("InsertAirport", connection);

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Country", location.country);
            cmd.Parameters.AddWithValue("@City", location.city);

            cmd.CommandType = CommandType.StoredProcedure;

            return Guid.Parse(SqlSelect(cmd).Rows[0]["ID"].ToString());
        }

        static public Guid InsertAirplaneAndReturnID(String name, Guid companyID, uint capacity)
        {
            SqlCommand cmd = new SqlCommand("InsertAirplane", connection);

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@CompanyID", companyID);
            cmd.Parameters.AddWithValue("@Capacity", (int)capacity);

            cmd.CommandType = CommandType.StoredProcedure;

            return Guid.Parse(SqlSelect(cmd).Rows[0]["ID"].ToString());
        }


        static public Guid InsertCompanyAndReturnID(String name)
        {
            SqlCommand cmd = new SqlCommand("InsertCompany", connection);

            cmd.Parameters.AddWithValue("@Name", name);

            cmd.CommandType = CommandType.StoredProcedure;

            return Guid.Parse(SqlSelect(cmd).Rows[0]["ID"].ToString());
        }

        //TODO: This function is broken, complete this.
        static public Guid InsertNewUserAndReturnStaffID(String username, String password, String fName, String lName, String rank)
        {
     
            SqlCommand cmd = new SqlCommand("[InsertStaffAndUser]", connection);

            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@FirstName", fName);
            cmd.Parameters.AddWithValue("@LastName", lName);
            cmd.Parameters.AddWithValue("@Rank", rank);

            cmd.CommandType = CommandType.StoredProcedure;

            return Guid.Parse(SqlSelect(cmd).Rows[0]["ID"].ToString());
        }

        static public Guid InsertReservationAndReturnID(Guid flightID,Guid passerngerID, Guid staffID, uint seatNumber)
        {
            SqlCommand cmd = new SqlCommand("InsertReservation", connection);

            cmd.Parameters.AddWithValue("@FlightID", flightID);
            cmd.Parameters.AddWithValue("@PassengerID", passerngerID);
            cmd.Parameters.AddWithValue("@StaffID", staffID);
            cmd.Parameters.AddWithValue("@SeatNumber", (int) seatNumber);

            cmd.CommandType = CommandType.StoredProcedure;

            return Guid.Parse(SqlSelect(cmd).Rows[0]["ID"].ToString());
        }

        static public void CancelReservation(Guid reservationID)
        {
            SqlCommand cmd = new SqlCommand("CancelReservation", connection);

            cmd.Parameters.AddWithValue("@ReservationID", reservationID);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlUpdate(cmd);
        }

        static public void UpdateFlight(Guid flightID, String newState, Nullable<DateTime> newActualDepartureDate, Nullable<DateTime> newActualArrivalDate)
        {
            //TODO write this.
        }

        //static public List<uint> GetReservedSeats(Guid flightID)
        //{


        //}
        static private DataTable SqlSelect(SqlCommand cmd)
        {
            try
            {
                connection.Open();
                cmd.Connection = connection;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        static private void SqlUpdate(SqlCommand cmd)
        {
            try
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

    }
}
