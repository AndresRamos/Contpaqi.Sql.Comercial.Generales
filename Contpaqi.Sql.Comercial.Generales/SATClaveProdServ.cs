using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Generales
{
    [Table("SATClaveProdServ")]
    public class SATClaveProdServ
    {
        [Key]
        [StringLength(10)]
        public string CCLAVE { get; set; }

        [Required]
        [StringLength(152)]
        public string CDESCRIPCION { get; set; }
    }
}