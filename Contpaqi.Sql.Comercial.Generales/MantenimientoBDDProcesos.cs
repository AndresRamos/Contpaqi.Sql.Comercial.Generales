using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Comercial.Generales
{
    public partial class MantenimientoBDDProcesos
    {
        [Key]
        [StringLength(36)]
        public string cGuidProceso { get; set; }

        public DateTime? cFechaInicial { get; set; }

        public DateTime? cFechaFinal { get; set; }

        public int? cLogsEliminados { get; set; }

        public int? cIndicesReorganizados { get; set; }

        public int? cIndicesReconstruidos { get; set; }

        public int? cUpdStatix { get; set; }
    }
}