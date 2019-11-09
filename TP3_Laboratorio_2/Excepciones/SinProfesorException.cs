using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException : Exception
    {
        #region Métodos

        public SinProfesorException() : base("No hay Profesor para la clase.")
        {
        }

        #endregion
    }
}
