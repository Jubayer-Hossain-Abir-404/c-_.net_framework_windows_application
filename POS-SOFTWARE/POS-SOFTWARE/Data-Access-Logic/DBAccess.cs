using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_SOFTWARE.Data_Access_Logic
{
    class DBAccess
    {
        public static SqlConnection objConnection;
        private static SqlDataAdapter objDataAdapter;

        public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\pos_software.mdf;Integrated Security=True;Connect Timeout=30";

        private static void OpenConnection()
        {
            try
            {
                if(objConnection == null)
                {
                    objConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\pos_software.mdf;Integrated Security=True;Connect Timeout=30");
                    objConnection.Open();
                }
                else
                {
                    if (objConnection.State != System.Data.ConnectionState.Open)
                    {
                        objConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\pos_software.mdf;Integrated Security=True;Connect Timeout=30");
                        objConnection.Open();
                    }
                }
            }
            catch
            {

            }
        }
        private static void CloseConnection()
        {
            try
            {
                if (!(objConnection == null))
                {
                    if (objConnection.State == System.Data.ConnectionState.Open)
                    {
                        objConnection.Close();
                        objConnection.Dispose();
                    }
                }
            }
            catch
            {

            }
        }

        public static DataTable FillDataTable(string query, DataTable Table)
        {
            try
            {
                OpenConnection();
                objDataAdapter = new SqlDataAdapter(query, objConnection);
                objDataAdapter.Fill(Table);
                objDataAdapter.Dispose();
                CloseConnection();
                return Table;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        public static bool ExecuteInsertQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }
                
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ExecuteQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static SqlDataReader ExecuteReader(string cmd)
        {
            try
            {

                SqlDataReader objReader;
                objConnection = new SqlConnection(ConnectionString);
                OpenConnection();
                SqlCommand cmdReader = new SqlCommand(cmd, objConnection);
                objReader = cmdReader.ExecuteReader(CommandBehavior.CloseConnection);
                cmdReader.Dispose();
                return objReader;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
