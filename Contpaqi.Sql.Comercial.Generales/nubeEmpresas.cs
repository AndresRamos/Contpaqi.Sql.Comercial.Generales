using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Comercial.Generales
{
    public class nubeEmpresas
    {
        [Key]
        [StringLength(253)]
        public string CIDEMPRESA { get; set; }

        [Required]
        [StringLength(253)]
        public string CEMPRESA { get; set; }

        [Required]
        [StringLength(20)]
        public string CRFC { get; set; }

        [Required]
        [StringLength(20)]
        public string CTIPO { get; set; }

        [Required]
        [StringLength(150)]
        public string CPROPIETARIO { get; set; }
    }
}