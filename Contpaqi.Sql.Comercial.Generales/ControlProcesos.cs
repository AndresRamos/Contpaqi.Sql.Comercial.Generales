using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Comercial.Generales
{
    public partial class ControlProcesos
    {
        [Key]
        [StringLength(36)]
        public string cGuidControl { get; set; }

        [StringLength(50)]
        public string cProcesoDescripcion { get; set; }

        public int? cPorcentaje { get; set; }

        public DateTime? cFechaInicial { get; set; }

        public DateTime? cFechaFinal { get; set; }

        public int? cTotalExtraccion { get; set; }

        public int? cTotalProcesado { get; set; }

        [StringLength(50)]
        public string cNombreLog { get; set; }

        [StringLength(50)]
        public string cEstatusProceso { get; set; }
    }
}