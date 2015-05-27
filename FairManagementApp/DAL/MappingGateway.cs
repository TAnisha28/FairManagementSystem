using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairManagementApp.DAL
{
    class MappingGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["FairConString"].ConnectionString;
        public void InsertIntoMapTable(int idZone, int idVisitor)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO table_mapping VALUES('" + idZone + "','" + idVisitor + "')";

            SqlCommand command = new SqlCommand(query, connection);

  
            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            //return rowAffected;
        }
    }
}
