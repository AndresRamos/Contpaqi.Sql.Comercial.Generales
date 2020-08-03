using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Generales
{
    public class FormatosEtiquetas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDTIPOHOJA { get; set; }

        [Required]
        [StringLength(30)]
        public string CNOMBREHOJA { get; set; }

        public double CLARGOPAPEL { get; set; }

        public double CANCHOPAPEL { get; set; }

        public double CMARGENIZQUIERDO { get; set; }

        public double CMARGENDERECHO { get; set; }

        public double CMARGENINFERIOR { get; set; }

        public double CMARGENSUPERIOR { get; set; }

        public int CNUMETIQUETAS { get; set; }

        public int CNUMRENGLONES { get; set; }
    }
}