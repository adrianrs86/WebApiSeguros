namespace WebApiSeguros.Dominio.Dtos.PersonaPolizas
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class RespuestaPersonaPolizas
    {
        public bool Valido { get; set; }

        public string MensajeError { get; set; }
    }
}
