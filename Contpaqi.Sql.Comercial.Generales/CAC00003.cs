using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Generales
{
    public class CAC00003
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDBITACORA { get; set; }

        [Column(TypeName = "text")]
        public string CMENSAJE { get; set; }
    }
}