using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bcp.Domain.Models
{
    public class StockWms
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Bin { get; set; }

        [Column(TypeName = "varchar(2)")]
        public string BinStatus { get; set; }
        public string CarBrand { get; set; }

        [Column(TypeName = "varchar(2)")]
        [Required]
        public string ContentStatus { get; set; }
        public DateTime? DryDate { get; set; }
        public DateTime? ExpDate { get; set; }

        [Column(TypeName = "varchar(2)")]
        public string GlassPos { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string GlassTyp { get; set; }
        public string LabelNr { get; set; }
        public string SerialNr { get; set; }
        public string BatchNr { get; set; }
        public string LabelStatus { get; set; }
        public string LotNr { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string Market { get; set; }
        public string MatGrp { get; set; }
        public string MatType { get; set; }
        public string PackNr { get; set; }
        [Required]
        public string Product { get; set; }
        public string ProdAdd { get; set; }
        public string ProdDsc2 { get; set; }
        public decimal? PrNetWeight { get; set; }
        [Column(TypeName = "varchar(5)")]
        public string PrWeightUnit { get; set; }
        [Required]
        public int? Qty { get; set; }
        [Required]
        public string RackId { get; set; }
        public decimal? RackTotWgt { get; set; }
        [Required]
        public string RackType { get; set; }
        public string ReasonCodeLong { get; set; }
        public decimal? RtNetWeight { get; set; }
        [Column(TypeName = "varchar(5)")]
        public string RtWeightUnit { get; set; }
        public string SapLoc { get; set; }
        public DateTime? StatusBDate { get; set; }
        public DateTime? StatusQDate { get; set; }
        public string WareHouse { get; set; }
        public string WorkCenter { get; set; }
        public string ZoneDsc { get; set; }
        [Column(TypeName = "varchar(5)")]
        [Required]
        public string Plant { get; set; }
        public string Delivery { get; set; }
    }
}
