using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region Atributos

        string nombre;
        string apellido;
        int dni;
        ENacionalidad nacionalidad;

        #endregion

        #region Enumerado

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        #endregion

        #region Propiedades

        public string Nombre { get { return this.nombre; } set { this.nombre = ValidarNombreApellido(value); } }

        public string Apellido { get { return this.apellido; } set { this.apellido = ValidarNombreApellido(value); } }

        public ENacionalidad Nacionalidad { get { return this.nacionalidad; } set { this.nacionalidad = value; } }

        public int DNI { get { return this.dni; } set { this.dni = ValidarDni(this.nacionalidad, value); } }

        public string StringToDNI { set { this.dni = ValidarDni(this.nacionalidad, value); } }

        #endregion

        #region Constructores

        public Persona() { }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        #endregion

        #region Métodos

        public override string ToString()
        {
            return string.Format("NOMBRE COMPLETO: {0}, {1}\nNACIONALIDAD: {2}\n", this.Apellido, this.Nombre, this.Nacionalidad);
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int datoInt;

            try
            {
                datoInt = int.Parse(dato);
            }
            catch (Exception)
            {
                throw new DniInvalidoException("DNI tiene algun error en el formato");
            }

            if (!(datoInt >= 1 && datoInt <= 99999999))
            {
                throw new DniInvalidoException("DNI no esta entre los limites establecidos");
            }

            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if (!(datoInt >= 1 && datoInt <= 89999999))
                    {
                        throw new NacionalidadInvalidaException("La nacionalidad no es argentina");
                    }
                    break;
                case ENacionalidad.Extranjero:
                    if (!(datoInt >= 90000000 && datoInt <= 99999999))
                    {
                        throw new NacionalidadInvalidaException("La nacionalidad no es extranjera");
                    }
                    break;
                default:
                    throw new NacionalidadInvalidaException("La nacionalidad invalida");
            }

            return datoInt;
        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            return ValidarDni(nacionalidad, dato.ToString());
        }

        private string ValidarNombreApellido(string dato)
        {

            foreach (char digit in dato)
            {
                if (!char.IsLetter(digit) || char.IsWhiteSpace(digit))
                {
                    dato = null;
                }
            }

            return dato;
        }

        #endregion
    }
}
