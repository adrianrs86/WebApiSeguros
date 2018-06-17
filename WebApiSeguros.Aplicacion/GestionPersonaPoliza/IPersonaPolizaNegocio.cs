namespace WebApiSeguros.Aplicacion.GestionPersonaPoliza
{
    using System.Collections.Generic;
    public interface IPersonaPolizaNegocio
    {
        Dominio.Dtos.PersonaPolizas.RespuestaPersonaPolizas Crear(Dominio.Dtos.PersonaPolizas.PersonaPolizas personaPolizas);
        List<Dominio.Dtos.PersonaPolizas.PersonaPolizaRegistro> ObtenerTodo();
    }
}
