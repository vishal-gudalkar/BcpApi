
namespace Bcp.Domain.Dtos
{
    public class StockChangesDto
    {
        public string LabelNr { get; set; }
        public string RackId { get; set; }
        public int FeildChangeType { get; set; }
        public string Bin { get; set; }
        public string SapLoc { get; set; }
        public string Status { get; set; }
    }
}
