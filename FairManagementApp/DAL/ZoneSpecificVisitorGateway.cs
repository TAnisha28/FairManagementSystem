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
    class ZoneSpecificVisitorGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["FairConString"].ConnectionString;
        public List<Visitor> GetAllVisitors(int zoneId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT table_mapping.Idvisitor,visitor_info.Name,visitor_info.Email,visitor_info.Contact FROM table_mapping,visitor_info WHERE table_mapping.Idzone='" + zoneId + "' AND table_mapping.Idvisitor=visitor_info.VisitorId";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();


            List<Visitor> visitors = new List<Visitor>();
            
            while (reader.Read())
            {
              
                Visitor aVisitor=new Visitor();
                aVisitor.visitorId = Convert.ToInt16(reader["Idvisitor"].ToString());

                aVisitor.name = reader["Name"].ToString();
                aVisitor.email = reader["Email"].ToString();
                aVisitor.contact = reader["Contact"].ToString();
               

                visitors.Add(aVisitor);
            }

            reader.Close();
            connection.Close();
            return visitors;
        }

        
    }
}
