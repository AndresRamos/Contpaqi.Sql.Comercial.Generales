using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Comercial.Generales
{
    public class SATFracciones
    {
        [Key]
        [StringLength(10)]
        public string CCLAVE { get; set; }

        [Required]
        [StringLength(3)]
        public string CUNIDAD { get; set; }
    }
}