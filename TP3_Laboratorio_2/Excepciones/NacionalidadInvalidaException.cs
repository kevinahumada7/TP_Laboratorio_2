using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        #region Métodos

        public NacionalidadInvalidaException() : base("La Nacionalidad no coincide con el DNI") { }

        public NacionalidadInvalidaException(string message) : base(message) { }

        #endregion
    }
}
