using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using EntidadesAbstractas;
using Excepciones;
using Archivos;

namespace Test_Unitario
{
    [TestClass]
    public class TestUnitario
    {
        [TestMethod]
        public void ArchivosExceptionTest()
        {
            try
            {
                Universidad utn = new Universidad();
                Universidad uba = new Universidad();

                utn = uba;
                uba = null;
                Universidad.Guardar(utn);
                Universidad.Guardar(uba);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ArchivosException));
            }
        }

        [TestMethod]
        public void DniInvalidoExceptionTest()
        {
            try
            {
                Alumno alumno = new Alumno(1, "Ezequiel", "Onysz", "43.234.520", Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
        }

        [TestMethod]
        public void DniTest()
        {
            Alumno alumno = new Alumno(1, "Alvaro", "Elena", "97255120", Persona.ENacionalidad.Extranjero, Universidad.EClases.SPD);
            alumno.StringToDNI = "98468742";

            Assert.AreEqual(98468742, alumno.DNI);
        }

        [TestMethod]
        public void ValoresNulos()
        {
            Profesor profe = new Profesor(1, "Brian Ignacio", "Ahumada", "16516", Persona.ENacionalidad.Argentino);
            Assert.IsNotNull(profe.Apellido);
            Assert.IsNull(profe.Nombre);
        }

    }
}
