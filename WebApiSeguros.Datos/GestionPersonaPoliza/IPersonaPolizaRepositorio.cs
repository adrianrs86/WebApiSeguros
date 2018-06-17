namespace WebApiSeguros.Datos.GestionPersonaPoliza
{
    using Modelo;
    using System.Collections.Generic;
    public interface IPersonaPolizaRepositorio
    {
        bool Crear(Dominio.Dtos.PersonaPolizas.PersonaPolizas personaPoliza);
        List<Dominio.Dtos.PersonaPolizas.PersonaPolizaRegistro> ObtenerTodo();
    }
}
