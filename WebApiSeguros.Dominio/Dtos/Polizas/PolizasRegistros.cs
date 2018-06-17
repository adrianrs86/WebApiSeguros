namespace WebApiSeguros.Dominio.Dtos.Polizas
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PolizasRegistros
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public decimal PorcentajeCobertura { get; set; }

        public int PeriodoCobertura { get; set; }

        public string NombreTipoRiesgo { get; set; }

        public int CodigoTipoRiesgo { get; set; }

        public string NombreTipoCubrimiento { get; set; }

        public int CodigoTipoCubrimiento { get; set; }

        public decimal Precio { get; set; }

        public DateTime Vigencia { get; set; }
    }
}
