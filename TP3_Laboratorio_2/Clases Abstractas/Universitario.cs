using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributos

        int legajo;

        #endregion

        #region Constructores

        public Universitario() : base()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion

        #region Métodos

        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                return true;
            }

            return false;
        }

        protected virtual string MostrarDatos()
        {
            return string.Format("{0}\nLEGAJO NUMERO: {1}\n", base.ToString(), this.legajo);
        }

        protected abstract string ParticiparEnClase();

        #endregion

        #region Sobrecargas

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (pg1.Equals(pg2) && (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        #endregion
    }
}
