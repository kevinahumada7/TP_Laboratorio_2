using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace Entidades
{
    public class Jornada
    {
        #region Atributos

        List<Alumno> alumnos;
        Universidad.EClases clase;
        Profesor instructor;

        #endregion

        #region Propiedades

        public List<Alumno> Alumnos { get { return this.alumnos; } set { this.alumnos = value; } }

        public Universidad.EClases Clase { get { return this.clase; } set { this.clase = value; } }

        public Profesor Instructor { get { return this.instructor; } set { this.instructor = value; } }

        #endregion

        #region Constructores

        private Jornada()
        {
            alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        #endregion

        #region Métodos

        public override string ToString()
        {
            string retorno = "";

            retorno += "CLASE DE: " + this.clase + " POR " + this.instructor.ToString();
            if (this.Alumnos.Count != 0)
            {
                retorno += "ALUMNOS: \n";

                foreach (Alumno alumno in this.alumnos)
                {
                    retorno += alumno.ToString() + "\n";
                }
            }
            else
            {
                retorno += "- NO HAY ALUMNOS PARA ESTA JORNADA... -\n";
            }


            return retorno;
        }

        public static string Leer()
        {

            Texto reader = new Texto();
            string retorno;

            try
            {
                reader.Leer("Jornada.txt", out retorno);
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }

            return retorno;
        }

        public static bool Guardar(Jornada jornada)
        {
            Texto writer = new Texto();

            try
            {
                return writer.Guardar("Jornada.txt", jornada.ToString());
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Jornada j, Alumno a)
        {
            if (j.alumnos.Contains(a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.Alumnos.Add(a);
            }

            return j;
        }

        #endregion
    }
}
