

namespace Bcp.Domain.Dtos
{
    public class StockWmsSearchDto
    {
        public string Bin { get; set; }
        public string LabelNr { get; set; }
        public string RackId { get; set; }
        public string MatType { get; set; }
        public string Delivery { get; set; }
        public string BatchNr { get; set; }
        public string SerialNr { get; set; }
        public string SapLoc { get; set; }
        public string ChckQty { get; set; }
    }
}
