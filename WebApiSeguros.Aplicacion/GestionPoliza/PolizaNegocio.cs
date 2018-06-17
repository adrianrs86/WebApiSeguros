namespace WebApiSeguros.Aplicacion.GestionPoliza
{
    using Base.Utilidades;
    using Datos.GestionPoliza;
    using Dominio.Dtos.Polizas;
    using System.Collections.Generic;
    using Base.Recursos;

    public class PolizaNegocio : IPolizaNegocio
    {
        readonly IPolizaRepositorio polizaRepositorio;

        public PolizaNegocio(IPolizaRepositorio polizaRepositorio)
        {
            this.polizaRepositorio = polizaRepositorio;
        }

        public RespuestaPoliza Crear(Poliza poliza)
        {
            var respuesta = new RespuestaPoliza();
            if (this.ValidarCubrimientoPoliza(poliza.PorcentajeCobertura, poliza.TipoRiesgo.ToString()))
            {
                var valido = polizaRepositorio.Crear(poliza);
                respuesta.Valido = valido;
            }
            else
            {
                respuesta.MensajeError = MensajesUsuario.CoberturaNoPermitida;
            }

            return respuesta;
        }

        public RespuestaPoliza Actualizar(Poliza poliza)
        {
            var respuesta = new RespuestaPoliza();
            if (this.ValidarCubrimientoPoliza(poliza.PorcentajeCobertura, poliza.TipoRiesgo.ToString()))
            {
                var valido = polizaRepositorio.Actualizar(poliza);
                respuesta.Valido = valido;
            }
            else
            {
                respuesta.MensajeError = MensajesUsuario.CoberturaNoPermitida;
            }

            return respuesta;
        }

        public List<PolizasRegistros> ObtenerTodo()
        {
            return this.polizaRepositorio.ObtenerTodo();
        }

        private bool ValidarCubrimientoPoliza(decimal cobertura, string tipoRiesgo)
        {
            if (Constantes.Riesgo_Alto.Codigo.Equals(tipoRiesgo) && cobertura > 50)
            {
                return false;
            }

            return true;
        }
    }
}
