using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Generales
{
    [Table("EmpresasModelo")]
    public class EmpresasModelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDEMPRESA { get; set; }

        [Required]
        [StringLength(150)]
        public string CNOMBREEMPRESA { get; set; }

        [Required]
        [StringLength(253)]
        public string CRUTAARCHIVOS { get; set; }
    }
}