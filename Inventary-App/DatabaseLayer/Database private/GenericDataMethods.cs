using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseLayer
{
    public sealed class GenericDataMethods
    {
        //private string databaseConnection = WebConfigurationManager.ConnectionStrings["LibroApp_Database"].ConnectionString;

        #region Metodos_CRUD
        public bool Agregar(Authors item)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Autores(Nombre, Correo) values(@nombre, @correo)", connection);

            sqlCommand.Parameters.AddWithValue("@nombre", item.Nombre);
            sqlCommand.Parameters.AddWithValue("@correo", item.Correo);

            return EjecutarConsulta(sqlCommand);
        }

        public bool Editar(Authors item)
        {
            SqlCommand sqlCommand = new SqlCommand("update Autores set Nombre = @nombre, Correo = @correo where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", item.Id);
            sqlCommand.Parameters.AddWithValue("@nombre", item.Nombre);
            sqlCommand.Parameters.AddWithValue("@correo", item.Correo);

            return EjecutarConsulta(sqlCommand);
        }

        public bool Eliminar(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("delete Autores where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            return EjecutarConsulta(sqlCommand);
        }

        public Authors EnlistarUno(int id)
        {
            Authors autor = new Authors();

            SqlCommand sqlCommand = new SqlCommand("select * from Autores where Id = @id", connection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    autor.Id = dataReader.IsDBNull(0) ? 0 : dataReader.GetInt32(0);
                    autor.Nombre = dataReader.IsDBNull(1) ? "NULL" : dataReader.GetString(1);
                    autor.Correo = dataReader.IsDBNull(2) ? "NULL" : dataReader.GetString(2);
                }

                dataReader.Close();
                dataReader.Dispose();

                connection.Close();

                return autor;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataTable EnlistarTodo()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Autores", connection);
            return ObtenerDatos(sqlDataAdapter);
        }
        #endregion

    }
}
