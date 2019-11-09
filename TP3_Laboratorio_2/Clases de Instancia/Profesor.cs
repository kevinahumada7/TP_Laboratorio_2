using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Entidades
{
    public sealed class Profesor : Universitario
    {
        #region Atributos

        Queue<Universidad.EClases> clasesDelDia;
        static Random random;

        #endregion

        #region Constructores

        static Profesor()
        {
            Profesor.random = new Random();
        }

        public Profesor() : base()
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }

        #endregion

        #region Métodos

        private void _randomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(1, 4));
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(1, 4));
        }

        protected override string MostrarDatos()
        {
            return string.Format("{0}\n{1}", base.MostrarDatos(), this.ParticiparEnClase());
        }

        protected override string ParticiparEnClase()
        {
            string retorno = "CLASES DEL DIA \n";

            foreach (Universidad.EClases clase in this.clasesDelDia)
            {
                retorno += clase + "\n";
            }

            retorno += "\n";

            return retorno;
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases claseDelProfesor in i.clasesDelDia)
            {
                if (claseDelProfesor == clase)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        #endregion
    }
}
