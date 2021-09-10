using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Generales
{
    public partial class MantenimientoBDDIndexTmps
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string cNombreTabla { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string cNombreIndex { get; set; }

        public int? cPorcentajeFragmentacion { get; set; }
    }
}