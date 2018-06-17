namespace WebApiSeguros.Controllers
{
    using Aplicacion.GestionPoliza;
    using Base.Recursos;
    using Dominio.Dtos.Polizas;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    public class PolizaController : ApiController
    {

        #region Constructores y atributos
        private readonly IPolizaNegocio polizaNegocio;
        #endregion

        public PolizaController(IPolizaNegocio polizaNegocio)
        {
            this.polizaNegocio = polizaNegocio;
        }

        [HttpPost]
        public HttpResponseMessage Crear(Poliza poliza)
        {
            var respuesta = new RespuestaPoliza();
            try
            {
                if (ModelState.IsValid)
                {
                    respuesta = polizaNegocio.Crear(poliza);
                    return Request.CreateResponse<RespuestaPoliza>(HttpStatusCode.OK, respuesta);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, MensajesUsuario.ErrorParametros);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, string.Format(MensajesUsuario.ErrorGeneral, ex.Message));
            }
        }

        [HttpGet]
        public HttpResponseMessage ObtenerTodo()
        {
            try
            {
                var lista = polizaNegocio.ObtenerTodo();
                return Request.CreateResponse<List<PolizasRegistros>>(HttpStatusCode.OK, lista);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, string.Format(MensajesUsuario.ErrorGeneral, ex.Message));
            }
        }

        [HttpPut]
        public HttpResponseMessage Actualizar(Poliza poliza)
        {
            var respuesta = new RespuestaPoliza();
            try
            {
                if (ModelState.IsValid)
                {
                    respuesta = polizaNegocio.Actualizar(poliza);
                    return Request.CreateResponse<RespuestaPoliza>(HttpStatusCode.OK, respuesta);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, MensajesUsuario.ErrorParametros);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, string.Format(MensajesUsuario.ErrorGeneral, ex.Message));
            }
        }

        [HttpDelete]
        public void Eliminar(int id)
        {

        }

        
    }
}
