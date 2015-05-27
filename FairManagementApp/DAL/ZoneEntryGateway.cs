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
    internal class ZoneEntryGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["FairConString"].ConnectionString;

        public int SaveZone(Zone aZone)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO zone_type VALUES('" + aZone.zoneName + "')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        }

        public bool IsZoneExist(string zoneName)
        {
            string query = "SELECT * FROM zone_type WHERE ZoneName ='" + zoneName + "'";
            SqlConnection aConnection = new SqlConnection(connectionString);
            aConnection.Open();
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader reader = aCommand.ExecuteReader();

            Zone aZone = new Zone();

            if (reader.HasRows)
            {
                reader.Read();
                aZone.zoneName = reader["ZoneName"].ToString();
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

        public List<Zone> GetAllZones()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM zone_type";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();


            List<Zone> zones = new List<Zone>();
            while (reader.Read())
            {

                Zone aZone = new Zone();
                aZone.zoneId = Convert.ToInt16(reader["ZoneId"].ToString());

                aZone.zoneName = reader["ZoneName"].ToString();
                aZone.zoneTotal = GetTotalVisitor(aZone.zoneId);
                zones.Add(aZone);
            }
            reader.Close();
            connection.Close();
            return zones;
        }

        public int GetTotalVisitor(int id)
        {
            int count = 0;
            Zone aZone = new Zone();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT Idvisitor FROM table_mapping WHERE Idzone = '" + id + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //Visitor aVisitor=new Visitor();
                //aVisitor.visitorId = Convert.ToInt16(reader["Idvisitor"].ToString());
                count++;
            }

            aZone.zoneTotal = 0;
            aZone.zoneTotal = count;

            reader.Close();
            connection.Close();
            return aZone.zoneTotal;
        }

        public int GetZoneIdByName(string zoneName)
        {


           
            
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT * FROM zone_type WHERE ZoneName='" + zoneName + "' ";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                Zone aZone = new Zone();
                while (reader.Read())
                {


                    aZone.zoneId = Convert.ToInt16(reader["ZoneId"].ToString());

                    //aZone.zoneName = reader["ZoneName"].ToString();
                    //aZone.zoneTotal = GetTotalVisitor(aZone.zoneId);
                    //zones.Add(aZone);
                }
                reader.Close();
                connection.Close();
                return aZone.zoneId;
            }


        }
    }


        
    

   
