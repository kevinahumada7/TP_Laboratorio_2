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
                Universidad utn = Universidad.Leer();
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ArchivosException));
            }
        }

        [TestMethod]
        public void NacionalidadExceptionTest()
        {
            try
            {
                Alumno alumno = new Alumno(1, "Ezequiel", "Onysz", "43234520", Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }

        [TestMethod]
        public void DniTest()
        {
            Alumno alumno = new Alumno(1, "Alvaro", "Elena", "97255120", Persona.ENacionalidad.Extranjero, Universidad.EClases.SPD);
            alumno.StringToDNI = "98468742";
            Assert.AreEqual(98468742, alumno.DNI);
            alumno.DNI = 97255120;
            Assert.AreEqual(97255120, alumno.DNI);
        }

        [TestMethod]
        public void ValoresNulos()
        {
            Profesor profe = new Profesor(1, "Brian Ignacio", "Ahumada", "37516320", Persona.ENacionalidad.Argentino);
            Assert.IsNotNull(profe.Apellido);
            Assert.IsNull(profe.Nombre);
        }

    }
}
