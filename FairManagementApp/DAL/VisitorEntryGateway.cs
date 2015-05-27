using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.Model;

namespace FairManagementApp.DAL
{
    class VisitorEntryGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["FairConString"].ConnectionString;

        public int SaveVisitor(Visitor aVisitor)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO visitor_info VALUES('" + aVisitor.name + "','" + aVisitor.email + "','" + aVisitor.contact + "')";

            SqlCommand command = new SqlCommand(query, connection);

            aVisitor.visitorId = GetVisitorIdByEmail(aVisitor.email);
            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        }
        public bool IsEmailExist(string email)
        {
            string query = "SELECT * FROM visitor_info WHERE Email ='" + email + "'";
            SqlConnection aConnection = new SqlConnection(connectionString);
            aConnection.Open();
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader reader = aCommand.ExecuteReader();

            Visitor aVisitor=new Visitor();

            if (reader.HasRows)
            {
                reader.Read();
                aVisitor.email = reader["Email"].ToString();
                reader.Close();
                aConnection.Close();

                return true;
            }
            else
            {
                reader.Close();
                aConnection.Close();
                return false;

            }



        }
        ZoneEntryGateway aZoneEntryGateway=new ZoneEntryGateway();
        public int GetVisitorIdByEmail(string email)
        {
            string query = "SELECT * FROM visitor_info WHERE Email ='" + email + "'";
            SqlConnection aConnection = new SqlConnection(connectionString);
            aConnection.Open();
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader reader = aCommand.ExecuteReader();

            Visitor aVisitor=new Visitor();

            if (reader.HasRows)
            {
                reader.Read();
                aVisitor.visitorId = int.Parse(reader["VisitorId"].ToString());
                reader.Close();
                aConnection.Close();
               
                return aVisitor.visitorId;
            }
            else
            {
                reader.Close();
                aConnection.Close();
                return 0;

            }
        }
    }
}
