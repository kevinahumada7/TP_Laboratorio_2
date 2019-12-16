using System;
using System.Data.SqlClient;
namespace Entidades
{
    public static class PaqueteDAO
    {
        #region Atributos

        private static SqlCommand comando;
        private static SqlConnection conexion;

        #endregion

        #region Metodos

        public static bool Insertar(Paquete p)
        {
            string cmd = string.Format("INSERT INTO Paquetes(direccionEntrega,trackingID,alumno) values('{0}','{1}','{2}')", p.DireccionEntrega, p.TrackingID, "Ahumada Kevin");
            try
            {
                comando.CommandText = cmd;
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                comando.Connection.Close();
            }
        }

        static PaqueteDAO()
        {
            conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        #endregion
    }
}
