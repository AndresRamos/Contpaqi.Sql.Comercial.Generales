using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Generales
{
    public class admVistasRelaciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDRELACION { get; set; }

        public int CIDSISTEMA { get; set; }

        public int CINDICEIDIOMA { get; set; }

        [Required]
        [StringLength(9)]
        public string CNOMBRENATIVOTABLA1 { get; set; }

        [Required]
        [StringLength(9)]
        public string CNOMBRENATIVOTABLA2 { get; set; }

        [Required]
        [StringLength(51)]
        public string CNOMBRERELACION { get; set; }

        [Required]
        [StringLength(201)]
        public string CSENTENCIAENLACE { get; set; }
    }
}