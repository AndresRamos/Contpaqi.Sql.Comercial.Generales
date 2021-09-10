using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Generales
{
    public partial class Etiquetas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDETIQUETA { get; set; }

        [Required]
        [StringLength(30)]
        public string CNOMBREETIQUETA { get; set; }

        public int CIMPRIMIRCONTORNO { get; set; }

        public int CIDTIPOHOJA { get; set; }

        public int CPOSICIONCODIGOBARRASX { get; set; }

        public int CPOSICIONCODIGOBARRASY { get; set; }

        public int CFORMATOCODIGOBARRAS { get; set; }

        [Required]
        [StringLength(5)]
        public string CSUPLEMENTO { get; set; }

        public int CORIENTACION { get; set; }

        public int CCOLORCODIGOBARRAS { get; set; }

        public int CDENSIDADCODIGOBARRAS { get; set; }

        public int CALTURACODIGOBARRAS { get; set; }

        public int CANCHOCODIGOBARRAS { get; set; }

        public int CAPARECETEXTOCODIGO { get; set; }

        public int CAPARECENOMBREPRODUCTO { get; set; }

        public int CPOSICIONNOMBREPRODUCTOX { get; set; }

        public int CPOSICIONNOMBREPRODUCTOY { get; set; }

        [Required]
        [StringLength(30)]
        public string CFUENTENOMBREPRODUCTO { get; set; }

        public int CTAMNOMBREPRODUCTO { get; set; }

        public int CCOLORNOMBREPRODUCTO { get; set; }

        public int CESTILONOMBREPRODUCTO { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTONOMBREPRODUCTO { get; set; }

        public int CALINEACIONNOMBREPRODUCTO { get; set; }

        public int CANCHONOMBREPRODUCTO { get; set; }

        public int CNUMLISTAPRECIOPRODUCTO { get; set; }

        public int CPOSICIONPRECIOPRODUCTOX { get; set; }

        public int CPOSICIONPRECIOPRODUCTOY { get; set; }

        [Required]
        [StringLength(30)]
        public string CFUENTEPRECIOPRODUCTO { get; set; }

        public int CTAMPRECIOPRODUCTO { get; set; }

        public int CCOLORPRECIOPRODUCTO { get; set; }

        public int CESTILOPRECIOPRODUCTO { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTOPRECIOPRODUCTO { get; set; }

        public int CALINEACIONPRECIOPRODUCTO { get; set; }

        public int CANCHOPRECIOPRODUCTO { get; set; }

        public int CAPARECECARACTERISTICA1 { get; set; }

        public int CPOSICIONCARACTERISTICA1X { get; set; }

        public int CPOSICIONCARACTERISTICA1Y { get; set; }

        [Required]
        [StringLength(30)]
        public string CFUENTECARACTERISTICA1 { get; set; }

        public int CTAMCARACTERISTICA1 { get; set; }

        public int CCOLORCARACTERISTICA1 { get; set; }

        public int CESTILOCARACTERISTICA1 { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTOCARACTERISTICA1 { get; set; }

        public int CALINEACIONCARACTERISTIC1 { get; set; }

        public int CANCHOCARACTERISTICA1 { get; set; }

        public int CAPARECECARACTERISTICA2 { get; set; }

        public int CPOSICIONCARACTERISTICA2X { get; set; }

        public int CPOSICIONCARACTERISTICA2Y { get; set; }

        [Required]
        [StringLength(30)]
        public string CFUENTECARACTERISTICA2 { get; set; }

        public int CTAMCARACTERISTICA2 { get; set; }

        public int CCOLORCARACTERISTICA2 { get; set; }

        public int CESTILOCARACTERISTICA2 { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTOCARACTERISTICA2 { get; set; }

        public int CALINEACIONCARACTERISTIC2 { get; set; }

        public int CANCHOCARACTERISTICA2 { get; set; }

        public int CAPARECECARACTERISTICA3 { get; set; }

        public int CPOSICIONCARACTERISTICA3X { get; set; }

        public int CPOSICIONCARACTERISTICA3Y { get; set; }

        [Required]
        [StringLength(30)]
        public string CFUENTECARACTERISTICA3 { get; set; }

        public int CTAMCARACTERISTICA3 { get; set; }

        public int CCOLORCARACTERISTICA3 { get; set; }

        public int CESTILOCARACTERISTICA3 { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTOCARACTERISTICA3 { get; set; }

        public int CALINEACIONCARACTERISTIC3 { get; set; }

        public int CANCHOCARACTERISTICA3 { get; set; }

        public int CNUMIMPUESTORETENCION { get; set; }

        public int CPOSICIONIMPUESTOX { get; set; }

        public int CPOSICIONIMPUESTOY { get; set; }

        [Required]
        [StringLength(30)]
        public string CFUENTEIMPUESTO { get; set; }

        public int CTAMIMPUESTO { get; set; }

        public int CCOLORIMPUESTO { get; set; }

        public int CESTILOIMPUESTO { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTOIMPUESTO { get; set; }

        public int CALINEACIONIMPUESTO { get; set; }

        public int CANCHOIMPUESTO { get; set; }

        public int CAPARECENUMEROLOTE { get; set; }

        public int CPOSICIONNUMEROLOTEX { get; set; }

        public int CPOSICIONNUMEROLOTEY { get; set; }

        [Required]
        [StringLength(30)]
        public string CFUENTENUMEROLOTE { get; set; }

        public int CTAMNUMEROLOTE { get; set; }

        public int CCOLORNUMEROLOTE { get; set; }

        public int CESTILONUMEROLOTE { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTONUMEROLOTE { get; set; }

        public int CALINEACIONNUMEROLOTE { get; set; }

        public int CANCHONUMEROLOTE { get; set; }

        public int CAPARECEFECHACADUCIDAD { get; set; }

        public int CPOSICIONFECHACADUCIDADX { get; set; }

        public int CPOSICIONFECHACADUCIDADY { get; set; }

        [Required]
        [StringLength(30)]
        public string CFUENTEFECHACADUCIDAD { get; set; }

        public int CTAMFECHACADUCIDAD { get; set; }

        public int CCOLORFECHACADUCIDAD { get; set; }

        public int CESTILOFECHACADUCIDAD { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTOFECHACADUCIDAD { get; set; }

        public int CALINEACIONFECHACADUCIDAD { get; set; }

        public int CANCHOFECHACADUCIDAD { get; set; }

        public int CAPARECEFECHAFABRICACION { get; set; }

        public int CPOSICIONFECHAFABRICACIOX { get; set; }

        public int CPOSICIONFECHAFABRICACIOY { get; set; }

        [Required]
        [StringLength(30)]
        public string CFUENTEFECHAFABRICACION { get; set; }

        public int CTAMFECHAFABRICACION { get; set; }

        public int CCOLORFECHAFABRICACION { get; set; }

        public int CESTILOFECHAFABRICACION { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTOFECHAFABRICACION { get; set; }

        public int CALINEACIONFECHAFABRICAC { get; set; }

        public int CANCHOFECHAFABRICACION { get; set; }

        public int CAPARECEPEDIMENTO { get; set; }

        public int CPOSICIONPEDIMENTOX { get; set; }

        public int CPOSICIONPEDIMENTOY { get; set; }

        [Required]
        [StringLength(30)]
        public string CFUENTEPEDIMENTO { get; set; }

        public int CTAMPEDIMENTO { get; set; }

        public int CCOLORPEDIMENTO { get; set; }

        public int CESTILOPEDIMENTO { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTOPEDIMENTO { get; set; }

        public int CALINEACIONPEDIMENTO { get; set; }

        public int CANCHOPEDIMENTO { get; set; }

        public int CAPARECEADUANA { get; set; }

        public int CPOSICIONADUANAX { get; set; }

        public int CPOSICIONADUANAY { get; set; }

        [Required]
        [StringLength(30)]
        public string CFUENTEADUANA { get; set; }

        public int CTAMADUANA { get; set; }

        public int CCOLORADUANA { get; set; }

        public int CESTILOADUANA { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTOADUANA { get; set; }

        public int CALINEACIONADUANA { get; set; }

        public int CANCHOADUANA { get; set; }

        public int CAPARECEFECHAPEDIMENTO { get; set; }

        public int CPOSICIONFECHAPEDIMENTOX { get; set; }

        public int CPOSICIONFECHAPEDIMENTOY { get; set; }

        [Required]
        [StringLength(30)]
        public string CFUENTEFECHAPEDIMENTO { get; set; }

        public int CTAMFECHAPEDIMENTO { get; set; }

        public int CCOLORFECHAPEDIMENTO { get; set; }

        public int CESTILOFECHAPEDIMENTO { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTOFECHAPEDIMENTO { get; set; }

        public int CALINEACIONFECHAPEDIMENTO { get; set; }

        public int CANCHOFECHAPEDIMENTO { get; set; }

        public int CAPARECETIPOCAMBIO { get; set; }

        public int CPOSICIONTIPOCAMBIOX { get; set; }

        public int CPOSICIONTIPOCAMBIOY { get; set; }

        [Required]
        [StringLength(30)]
        public string CFUENTETIPOCAMBIO { get; set; }

        public int CTAMTIPOCAMBIO { get; set; }

        public int CCOLORTIPOCAMBIO { get; set; }

        public int CESTILOTIPOCAMBIO { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTOTIPOCAMBIO { get; set; }

        public int CALINEACIONTIPOCAMBIO { get; set; }

        public int CANCHOTIPOCAMBIO { get; set; }

        public int CAPARECESERIE { get; set; }

        public int CPOSICIONSERIEX { get; set; }

        public int CPOSICIONSERIEY { get; set; }

        [Required]
        [StringLength(30)]
        public string CFUENTESERIE { get; set; }

        public int CTAMSERIE { get; set; }

        public int CCOLORSERIE { get; set; }

        public int CESTILOSERIE { get; set; }

        [Required]
        [StringLength(30)]
        public string CTEXTOSERIE { get; set; }

        public int CALINEACIONSERIE { get; set; }

        public int CANCHOSERIE { get; set; }

        public int CINCIVA { get; set; }
    }
}