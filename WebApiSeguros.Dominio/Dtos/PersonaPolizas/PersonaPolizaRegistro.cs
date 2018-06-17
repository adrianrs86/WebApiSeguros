namespace WebApiSeguros.Dominio.Dtos.PersonaPolizas
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class PersonaPolizaRegistro
    {
        public int Id { get; set; }

        public int PolizaId { get; set; }
        public string NombrePoliza { get; set; }

        public string PersonaId { get; set; }
    }
}
