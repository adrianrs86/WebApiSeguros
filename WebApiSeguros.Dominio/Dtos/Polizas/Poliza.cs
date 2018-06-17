namespace WebApiSeguros.Dominio.Dtos.Polizas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    [DataContract(Name = "Poliza")]
    public class Poliza
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la póliza es requerido.")]
        [StringLength(50, ErrorMessage = "Se excede la longitud del campo.")]
        [RegularExpression("^[a-z, A-Z, 0-9]+-?[0-9]*$", ErrorMessage = "Error en parámetros.")]
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }

        [StringLength(500, ErrorMessage = "Se excede la longitud del campo.")]
        [RegularExpression("^[a-z, A-Z, 0-9]+-?[0-9]*$", ErrorMessage = "Error en parámetros.")]
        [DataMember(Name = "descripcion")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El tipo de cubrimiento es requerido.")]
        [DataMember(Name = "tipoCubrimiento")]
        public int TipoCubrimiento { get; set; }

        [Required(ErrorMessage = "El porcentaje de cobertura es requerido.")]
        [Range(1, 100, ErrorMessage = "El rango de cobertura debe ser entre 1 y 100%")]
        [DataMember(Name = "porcentajeCobertura")]
        public decimal PorcentajeCobertura { get; set; }

        [Required(ErrorMessage = "El inicio de vigencia es requerido.")]
        [DataMember(Name = "inicioVigencia")]
        public DateTime InicioVigencia { get; set; }

        [Required(ErrorMessage = "El periodo de cobertura es requerido.")]
        [Range(1, 12, ErrorMessage = "El periodo de cobertura debe ser entre 1 y 12 meses.")]
        [DataMember(Name = "periodoCobertura")]
        public int PeriodoCobertura { get; set; }

        [Required(ErrorMessage = "El precio es requerido.")]
        [DataMember(Name = "precio")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El tipo de riesgo es requerido.")]
        [DataMember(Name = "tipoRiesgo")]
        public int TipoRiesgo { get; set; }
    }
}
