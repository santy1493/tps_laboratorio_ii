using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class ConexionDB
    {
        static SqlConnection conexion;
        static SqlCommand comando;
        static SqlDataReader reader;

        static ConexionDB()
        {
            conexion = new SqlConnection("Server = DESKTOP-9UNRGHS; Database = PAISES_DB; Trusted_Connection = True;");

            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Pais> TraerDatos()
        {

            try
            {
                List<Pais> auxLista = new List<Pais>();

                comando.CommandText = "select * from paises";

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Pais aux = new Pais(reader["nombre"].ToString(), Pais.ValidarContinente(reader["continente"].ToString()), long.Parse(reader["poblaciontotal"].ToString()),
                        long.Parse(reader["infectados"].ToString()), long.Parse(reader["fallecidos"].ToString()), long.Parse(reader["vacunados"].ToString()));
                    auxLista.Add(aux);
                }

                return auxLista;
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                conexion.Close();

            }
        }

        public static void Insertar(List<Pais> listaPaises)
        {
            BorrarDatosTabla();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.CommandText = "insert into paises values (@nombre, @continente, @poblacionTotal, @infectados, @fallecidos, @vacunados)";

                foreach (Pais p in listaPaises)
                {

                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@nombre", p.Nombre);
                    comando.Parameters.AddWithValue("@continente", p.Continente.ToString());
                    comando.Parameters.AddWithValue("@poblacionTotal", p.PoblacionTotal.ToString());
                    comando.Parameters.AddWithValue("@infectados", p.Infectados.ToString());
                    comando.Parameters.AddWithValue("@fallecidos", p.Fallecidos.ToString());
                    comando.Parameters.AddWithValue("@vacunados", p.Vacunados.ToString());

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                conexion.Close();

            }
        }

        private static void BorrarDatosTabla()
        {

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            comando.CommandText = "delete from paises";
            comando.ExecuteNonQuery();

        }

    }
}
