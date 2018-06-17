namespace WebApiSeguros.Dominio.Dtos.PersonaPolizas
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    public class PersonaPolizas
    {
        [Required(ErrorMessage = "El identificador de la persona es requerido.")]
        [StringLength(10, ErrorMessage = "Se excede la longitud del campo.")]
        [RegularExpression("^[a-z, A-Z, 0-9]+-?[0-9]*$", ErrorMessage = "Error en parámetros.")]
        [DataMember(Name = "personaId")]
        public string PersonaId { get; set; }

        [Required(ErrorMessage = "La póliza es requerida.")]
        [DataMember(Name = "polizaId")]
        public int PolizaId { get; set; }
    }
}
