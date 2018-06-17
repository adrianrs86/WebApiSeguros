namespace WebApiSeguros.Tests.Repositorios.Polizas
{
    using Datos.GestionPoliza;
    using Dominio.Dtos.Polizas;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PolizaRepositorioTest
    {
        #region Miembros
        private IPolizaRepositorio polizaRepositorio;
        #endregion

        [TestInitialize]
        public void TestInicialize()
        {
            polizaRepositorio = new PolizaRepositorio();
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void CrearPoliza()
        {
            //Arrange
            var poliza = new Poliza()
            {
                Nombre = "PolizaPrueba",
                Descripcion = "Poliza de prueba",
                TipoCubrimiento = 1,
                PorcentajeCobertura = 40,
                InicioVigencia = System.DateTime.Now,
                PeriodoCobertura = 10,
                Precio = 50000,
                TipoRiesgo = 1
            };

            //Act
            var respuesta = polizaRepositorio.Crear(poliza);

            //Asert
            Assert.IsTrue(respuesta);
        }
    }
}
