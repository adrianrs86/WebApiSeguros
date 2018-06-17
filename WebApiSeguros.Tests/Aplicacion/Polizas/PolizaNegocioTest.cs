namespace WebApiSeguros.Tests.Aplicacion.Polizas
{
    using Datos.GestionPoliza;
    using Dominio.Dtos.Polizas;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NSubstitute;
    using WebApiSeguros.Aplicacion.GestionPoliza;

    [TestClass]
    public class PolizaNegocioTest
    {
        #region Miembros
        private IPolizaRepositorio polizaRepositorio;
        private IPolizaNegocio polizaNegocio;
        #endregion

        [TestInitialize]
        public void TestInicialize()
        {
            polizaRepositorio = Substitute.For<IPolizaRepositorio>();
            polizaNegocio = new PolizaNegocio(polizaRepositorio);
        }

        [TestMethod]
        private void ValidarRiesgoAlto_Y_CoverturaMayor_A_50()
        {
            //Arrange
            var poliza = new Poliza()
            {
                TipoRiesgo = 1,
                PorcentajeCobertura = 60
            };

            //Act
            var respuesta = polizaNegocio.Crear(poliza);

            //Asert
            Assert.IsFalse(respuesta.Valido);
        }

        [TestMethod]
        private void ValidarRiesgoAlto_Y_CoverturaMenor_A_50()
        {
            //Arrange
            var poliza = new Poliza()
            {
                TipoRiesgo = 1,
                PorcentajeCobertura = 40
            };

            this.polizaRepositorio.Crear(poliza).Returns(true);

            //Act
            var respuesta = polizaNegocio.Crear(poliza);

            //Asert
            Assert.IsTrue(respuesta.Valido);
        }

        [TestMethod]
        private void Validar_Riesgo_No_Alto()
        {
            //Arrange
            var poliza = new Poliza()
            {
                TipoRiesgo = 2,
                PorcentajeCobertura = 80
            };

            this.polizaRepositorio.Crear(poliza).Returns(true);

            //Act
            var respuesta = polizaNegocio.Crear(poliza);

            //Asert
            Assert.IsTrue(respuesta.Valido);
        }

    }
}
