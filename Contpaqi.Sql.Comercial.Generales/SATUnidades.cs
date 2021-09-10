using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Comercial.Generales
{
    public partial class SATUnidades
    {
        [Key]
        [StringLength(3)]
        public string CCLAVE { get; set; }

        [Required]
        [StringLength(100)]
        public string CNOMBRE { get; set; }

        [Required]
        [StringLength(512)]
        public string CDESCRIPCION { get; set; }
    }
}