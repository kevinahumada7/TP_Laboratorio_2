using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace Entidades
{
    public class Universidad
    {
        #region Atributos

        List<Alumno> alumnos;
        List<Jornada> jornada;
        List<Profesor> profesores;

        #endregion

        #region Enumerado

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD,
        }

        #endregion

        #region Propiedades

        public List<Alumno> Alumnos { get { return this.alumnos; } set { this.alumnos = value; } }

        public List<Profesor> Instructores { get { return this.profesores; } set { this.profesores = value; } }

        public List<Jornada> Jornadas { get { return this.jornada; } set { this.jornada = value; } }

        public Jornada this[int i] { get { return this.jornada[i]; } set { this.jornada[i] = value; } }

        #endregion

        #region Constructores

        public Universidad()
        {
            this.profesores = new List<Profesor>();
            this.jornada = new List<Jornada>();
            this.alumnos = new List<Alumno>();
        }

        #endregion

        #region Métodos

        private static string MostrarDatos(Universidad uni)
        {
            string retorno = "JORNADA: \n";

            foreach (Jornada jornada in uni.Jornadas)
            {
                retorno += jornada.ToString();
                retorno += "<------------------------------------------------------>" + "\n";
            }

            return retorno;
        }

        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }

        public static Universidad Leer()
        {
            Xml<Universidad> reader = new Xml<Universidad>();
            Universidad retorno = new Universidad();

            reader.Leer("Universidad.xml", out retorno);

            return retorno;
        }

        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> writer = new Xml<Universidad>();

            return writer.Guardar("Universidad.xml", uni);
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor instructor in g.Instructores)
            {
                if (instructor == i)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor profesor in u.Instructores)
            {
                if (profesor == clase)
                {
                    return profesor;
                }
            }
            throw new SinProfesorException();
        }

        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor profesor in u.Instructores)
            {
                if (profesor != clase)
                {
                    return profesor;
                }
            }
            throw new SinProfesorException();
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            try
            {
                Jornada nuevaJornada = new Jornada(clase, g == clase);

                foreach (Alumno alumno in g.Alumnos)
                {
                    if (alumno == nuevaJornada.Clase && nuevaJornada.Instructor.DNI != alumno.DNI)
                    {
                        nuevaJornada += alumno;
                    }
                }

                g.jornada.Add(nuevaJornada);
            }
            catch (SinProfesorException e)
            {
                throw e;
            }

            return g;
        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.Alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }

            return u;
        }

        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {
                u.Instructores.Add(i);
            }

            return u;
        }

        #endregion
    }
}
