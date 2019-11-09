using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        string mensajeBase;

        #region Métodos

        public DniInvalidoException() : this("Formato de DNI invalido.")
        {
        }

        public DniInvalidoException(Exception e) : this("Formato de DNI invalido.", e)
        {
        }

        public DniInvalidoException(string mensaje) : base(mensaje)
        {
            this.mensajeBase = mensaje;
        }

        public DniInvalidoException(string mensaje, Exception e) : base(mensaje, e)
        {
        }

        #endregion
    }
}
