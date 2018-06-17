namespace WebApiSeguros.Controllers
{
    using Aplicacion.GestionPersonaPoliza;
    using Base.Recursos;
    using Dominio.Dtos.PersonaPolizas;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    public class PersonaPolizaController : ApiController
    {
        #region Miembros
        private readonly IPersonaPolizaNegocio personaPolizasNegocio;
        #endregion

        public PersonaPolizaController(IPersonaPolizaNegocio personaPolizasNegocio)
        {
            this.personaPolizasNegocio = personaPolizasNegocio;
        }

        [HttpPost]
        public HttpResponseMessage Crear(PersonaPolizas personaPoliza)
        {
            var respuesta = new RespuestaPersonaPolizas();
            try
            {
                if (ModelState.IsValid)
                {
                    respuesta = personaPolizasNegocio.Crear(personaPoliza);
                    return Request.CreateResponse<RespuestaPersonaPolizas>(HttpStatusCode.OK, respuesta);
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
                var lista = personaPolizasNegocio.ObtenerTodo();
                return Request.CreateResponse<List<PersonaPolizaRegistro>>(HttpStatusCode.OK, lista);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, string.Format(MensajesUsuario.ErrorGeneral, ex.Message));
            }
        }
    }
}
