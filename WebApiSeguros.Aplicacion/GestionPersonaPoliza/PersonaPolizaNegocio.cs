namespace WebApiSeguros.Aplicacion.GestionPersonaPoliza
{
    using Datos.GestionPersonaPoliza;
    using Datos.Modelo;
    using System.Collections.Generic;

    public class PersonaPolizaNegocio : IPersonaPolizaNegocio
    {
        #region Miembros
        private readonly IPersonaPolizaRepositorio personaPolizaRepositorio;
        #endregion

        public PersonaPolizaNegocio(IPersonaPolizaRepositorio personaPolizaRepositorio)
        {
            this.personaPolizaRepositorio = personaPolizaRepositorio;
        }
        public Dominio.Dtos.PersonaPolizas.RespuestaPersonaPolizas Crear(Dominio.Dtos.PersonaPolizas.PersonaPolizas personaPolizas)
        {
            var respuesta = new Dominio.Dtos.PersonaPolizas.RespuestaPersonaPolizas();
            respuesta.Valido = this.personaPolizaRepositorio.Crear(personaPolizas);
            return respuesta;
        }

        public List<Dominio.Dtos.PersonaPolizas.PersonaPolizaRegistro> ObtenerTodo()
        {
            return this.personaPolizaRepositorio.ObtenerTodo();
        }
    }
}
