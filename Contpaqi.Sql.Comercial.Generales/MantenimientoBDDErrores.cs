using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Comercial.Generales
{
    public partial class MantenimientoBDDErrores
    {
        [Key]
        [StringLength(36)]
        public string cGuidProceso { get; set; }

        [Required]
        [StringLength(150)]
        public string cAliasBDD { get; set; }

        [StringLength(50)]
        public string cDescripcionError { get; set; }
    }
}