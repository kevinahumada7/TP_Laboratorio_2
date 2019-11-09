using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        #region Métodos
        public ArchivosException(Exception exception) : base("No se ha podido Leer o Guardar el archivo correspondiente.")
        {
        }

        #endregion
    }
}
