using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        #region Métodos

        public bool Guardar(string archivo, string datos)
        {
            try
            {
                StreamWriter writer = new StreamWriter(archivo);
                writer.Write(datos);
                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        public bool Leer(string archivo, out string datos)
        {
            try
            {
                StreamReader reader = new StreamReader(archivo);
                datos = reader.ReadToEnd();
                reader.Close();
                return true;
            }
            catch (Exception e)
            {
                datos = null;
                throw new ArchivosException(e);
            }
        }

        #endregion
    }
}
