using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseLayer.Database_private
{
    public sealed class DatabaseMethods 
    {
        public static DatabaseMethods Instance { get; set; } = new DatabaseMethods(DatabaseConfig.ConnectionString);

        private SqlConnection Connection { get; set; }

        private DatabaseMethods(string connection)
        {
            SqlConnection sqlConnection = new SqlConnection(connection);

            Connection = sqlConnection;
        }

        #region Ejecutores_SQL
        private DataTable ObtenerDatos(SqlDataAdapter dataAdapter)
        {
            try
            {
                DataTable data = new DataTable();

                Connection.Open();
                dataAdapter.Fill(data);
                Connection.Close();

                return data;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private bool EjecutarConsulta(SqlCommand command)
        {
            try
            {
                Connection.Open();
                command.ExecuteNonQuery();
                Connection.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion
    }
}
