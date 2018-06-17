namespace WebApiSeguros.Datos.GestionPoliza
{
    using Dominio.Dtos.Polizas;
    using System.Collections.Generic;

    public interface IPolizaRepositorio
    {
        List<PolizasRegistros> ObtenerTodo();
        List<PolizasRegistros> ObtenerPorId(int idPoliza);
        bool Actualizar(Poliza poliza);
        bool Crear(Poliza poliza);
    }
}
