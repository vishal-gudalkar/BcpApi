using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bcp.Domain.Models
{
    public class Classification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Material { get; set; }
        public DateTime? Created { get; set; }

        [Column(name: "old mat.no")]
        public string OldMatNo { get; set; }
        public string MaterialNumber { get; set; }
        public string CarSegment { get; set; }
        public string CarModel { get; set; }
        public string TabiaClassif { get; set; }
        public string CarMarket { get; set; }
        public string PositionV2 { get; set; }
        public string SideV2 { get; set; }
        public string CompositionV2 { get; set; } 
        public string WidthV2 { get; set; }
        public string HeightV2 { get; set; }
        public string TextADVEN { get; set; }
        public string TextADVFR { get; set; }
        public DateTime? LastChg { get; set; }
        public string Changedby { get; set; }
        public string Clt { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string MTyp { get; set; }
        public string MatlGroup { get; set; }
        public string Customerpartno { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string BUn { get; set; }
        public string GrossWeight { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string WUn { get; set; }
        public string NetWeight { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string WUn1 { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string Ms { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string St { get; set; }
        public string Material1 { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string Plnt { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string Pl { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string B { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string Ms1 { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string PGr { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string MRPpr { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string Typ { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string Mrpc { get; set; }
        public string Pdt { get; set; }
        public string Grt { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string Pi { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string Ls { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string ProcType { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string Spt { get; set; }
        public string SafetyStock { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string BUn1 { get; set; }

        [Column(name: "Min.LotSze")]
        public string MinLotSze { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string BUn2 { get; set; }
        public string ReorderPoint { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string BUn3 { get; set; }

        [Column(name: "Max.LotSize")]
        public string MaxLotSize { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string BUn4 { get; set; }

        [Column(name: "Fix.lotsize")]
        public string FixLotSize { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string BUn5 { get; set; }

        [Column(name: "Roundingval.")]
        public string Roundingval { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string BUn6 { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string B1 { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string Ipt { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string Trlt { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string LGrp { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string Bmr { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string Av { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string Planningtimefence { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string Consumptionmode { get; set; }
        public string CostingLotSize { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string BUn7 { get; set; }

        [Column(name: "Profl.", TypeName = "varchar(5)")]
        public string Profl { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string Plnt1 { get; set; }
        public string Material2 { get; set; }
        public string CustomerPlanNumber { get; set; }
        public string Cuttingprogram { get; set; }
        public string Layernumber { get; set; }
        public string CRNorm { get; set; }
        public string Internalplannumber { get; set; }
        public string TechnicalDocnewproduct { get; set; }
        public string SupportTechnicalDocument { get; set; }
        public string Amendment { get; set; }
        public string Lighttransmission { get; set; }
        public string Glassmatrix { get; set; }
        public string Dangerousproduct { get; set; }
        public string Navigability { get; set; }
        public string Militaryproduct { get; set; }
        public string PNManufacturer { get; set; }
        public string Assemblyscrap { get; set; }
        public string MaterialGroup { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string EmplacementMM { get; set; }
    }
}
