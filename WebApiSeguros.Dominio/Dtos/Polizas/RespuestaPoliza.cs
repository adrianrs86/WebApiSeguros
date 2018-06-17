namespace WebApiSeguros.Dominio.Dtos.Polizas
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RespuestaPoliza
    {
        public bool Valido { get; set; }

        public string MensajeError { get; set; }
    }
}
