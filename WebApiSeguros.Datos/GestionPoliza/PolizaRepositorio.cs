namespace WebApiSeguros.Datos.GestionPoliza
{
    using Dominio.Dtos.Polizas;
    using Modelo;
    using System.Collections.Generic;
    using System.Linq;

    public class PolizaRepositorio : IPolizaRepositorio
    {
        public List<PolizasRegistros> ObtenerTodo()
        {
            var lista = new List<PolizasRegistros>();
            using (var dbContext = new SegurosEntities())
            {
                lista = (from p in dbContext.Polizas
                         join c in dbContext.CubrimientoPolizas on p.CodigoCubrimiento equals c.Codigo
                         join r in dbContext.RiesgosPolizas on p.CodigoRiesgo equals r.Codigo
                         select new PolizasRegistros()
                         {
                             Id = p.Id,
                             Nombre = p.Nombre,
                             PorcentajeCobertura = p.PorcentajeCobertura,
                             PeriodoCobertura = p.PeriodoCobertura,
                             NombreTipoRiesgo = r.Nombre,
                             CodigoTipoRiesgo = r.Codigo,
                             NombreTipoCubrimiento = c.Nombre,
                             CodigoTipoCubrimiento = c.Codigo,
                             Precio = p.Precio.Value,
                             Vigencia = p.InicioVigencia
                         }).ToList();
            }

            return lista;
        }

        public List<PolizasRegistros> ObtenerPorId(int idPoliza)
        {
            var lista = new List<PolizasRegistros>();
            using (var dbContext = new SegurosEntities())
            {
                lista = (from p in dbContext.Polizas
                         join c in dbContext.CubrimientoPolizas on p.CodigoCubrimiento equals c.Codigo
                         join r in dbContext.RiesgosPolizas on p.CodigoRiesgo equals r.Codigo
                         where p.Id == idPoliza
                         select new PolizasRegistros()
                         {
                             Id = p.Id,
                             Nombre = p.Nombre,
                             PorcentajeCobertura = p.PorcentajeCobertura,
                             PeriodoCobertura = p.PeriodoCobertura,
                             NombreTipoRiesgo = r.Nombre,
                             CodigoTipoRiesgo = r.Codigo,
                             NombreTipoCubrimiento = c.Nombre,
                             CodigoTipoCubrimiento = c.Codigo,
                             Precio = p.Precio.Value,
                             Vigencia = p.InicioVigencia
                         }).ToList();
            }

            return lista;
        }

        public bool Actualizar(Poliza poliza)
        {
            using (var dbContext = new SegurosEntities())
            {
                var registro = dbContext.Polizas.Where(x => x.Id == poliza.Id).FirstOrDefault();
                if (registro != null)
                {
                    registro.Nombre = poliza.Nombre;
                    registro.Descripcion = poliza.Descripcion;
                    registro.CodigoCubrimiento = poliza.TipoCubrimiento;
                    registro.PorcentajeCobertura = poliza.PorcentajeCobertura;
                    registro.InicioVigencia = poliza.InicioVigencia;
                    registro.PeriodoCobertura = poliza.PeriodoCobertura;
                    registro.Precio = poliza.Precio;
                    registro.CodigoRiesgo = poliza.TipoRiesgo;

                    dbContext.SaveChanges();
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public bool Crear(Poliza poliza)
        {
            int filas = 0;
            using (var dbContext = new SegurosEntities())
            {
                var registro = new Polizas()
                {
                    Nombre = poliza.Nombre,
                    Descripcion = poliza.Descripcion,
                    CodigoCubrimiento = poliza.TipoCubrimiento,
                    PorcentajeCobertura = poliza.PorcentajeCobertura,
                    InicioVigencia = poliza.InicioVigencia,
                    PeriodoCobertura = poliza.PeriodoCobertura,
                    Precio = poliza.Precio,
                    CodigoRiesgo = poliza.TipoRiesgo
                };

                dbContext.Polizas.Add(registro);
                filas = dbContext.SaveChanges();
            }

            return filas > 0 ? true : false;
        }

    }
}
