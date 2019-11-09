using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T> where T : class
    {
        #region Métodos

        public bool Guardar(string archivo, T datos)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                TextWriter writer = new StreamWriter(archivo);

                xml.Serialize(writer, datos);
                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        public bool Leer(string archivo, out T datos)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                TextReader reader = new StreamReader(archivo);

                datos = (T)xml.Deserialize(reader);
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
