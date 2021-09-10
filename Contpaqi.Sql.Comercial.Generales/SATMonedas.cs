using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Comercial.Generales
{
    public partial class SATMonedas
    {
        [Key]
        [StringLength(3)]
        public string CCODIGO { get; set; }

        [Required]
        [StringLength(100)]
        public string CNOMBRE { get; set; }

        public int CDECIMALES { get; set; }
    }
}