namespace WebApiSeguros.Aplicacion.GestionPoliza
{
    using System.Collections.Generic;
    using WebApiSeguros.Dominio.Dtos.Polizas;

    public interface IPolizaNegocio
    {
        RespuestaPoliza Crear(Poliza poliza);

        List<PolizasRegistros> ObtenerTodo();

        RespuestaPoliza Actualizar(Poliza poliza);
    }
}
