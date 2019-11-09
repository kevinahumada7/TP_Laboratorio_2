using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;


namespace Entidades
{
    public sealed class Alumno : Universitario
    {
        #region Atributos

        Universidad.EClases claseQueToma;
        EEstadoCuenta estadoCuenta;

        #endregion

        #region Enumerado

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        #endregion

        #region Constructores

        public Alumno() : base()
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
            this.estadoCuenta = EEstadoCuenta.AlDia;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        #endregion

        #region Métodos

        protected override string MostrarDatos()
        {
            return string.Format("{0}\nESTADO DE CUENTA: {1}\n{2}\n", base.MostrarDatos(), this.estadoCuenta, this.ParticiparEnClase());
        }

        protected override string ParticiparEnClase()
        {
            return "TOMA CLASE DE " + this.claseQueToma;
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a == clase);
        }

        #endregion
    }
}
