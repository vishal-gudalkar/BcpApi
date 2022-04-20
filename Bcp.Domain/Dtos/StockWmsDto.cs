namespace Bcp.Domain.Dtos
{
    public class StockWmsDto
    {

        public int Id { get; set; }
        public string Bin { get; set; }
        public string BinStatus { get; set; }
        public string CarBrand { get; set; }
        public string ContentStatus { get; set; }
        public DateTime? DryDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public string GlassPos { get; set; }
        public string GlassTyp { get; set; }
        public string LabelNr { get; set; }
        public string SerialNr { get; set; }
        public string BatchNr { get; set; }
        public string LabelStatus { get; set; }
        public string LotNr { get; set; }
        public string Market { get; set; }
        public string MatGrp { get; set; }
        public string MatType { get; set; }
        public string PackNr { get; set; }
        public string Product { get; set; }
        public string ProdAdd { get; set; }
        public string ProdDsc2 { get; set; }
        public decimal? PrNetWeight { get; set; }
        public string PrWeightUnit { get; set; }
        public int? Qty { get; set; }
        public string RackId { get; set; }
        public decimal? RackTotWgt { get; set; }
        public string RackType { get; set; }
        public string ReasonCodeLong { get; set; }
        public decimal? RtNetWeight { get; set; }
        public string RtWeightUnit { get; set; }
        public string SapLoc { get; set; }
        public DateTime? StatusBDate { get; set; }
        public DateTime? StatusQDate { get; set; }
        public string WareHouse { get; set; }
        public string WorkCenter { get; set; }
        public string ZoneDsc { get; set; }
        public string Plant { get; set; }
        public string Delivery { get; set; }
    }
}
