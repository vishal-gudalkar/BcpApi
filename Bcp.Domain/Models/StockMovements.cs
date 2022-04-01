using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bcp.Domain.Models
{
    public class StockMovements
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TmStmp { get; set; }
        [DefaultValue("-")]
        public string User { get; set; }
        [Column(TypeName = "varchar(5)")]
        public string Plant { get; set; }
        public string SapLoc { get; set; }
        public string LabelNr { get; set; }
        public string SerialNr { get; set; }
        public string BatchNr { get; set; }
        public string RackId { get; set; }
        public string RackType { get; set; }
        public string Bin { get; set; }
        public string Product { get; set; }
        public int? Qty { get; set; }
        public string ContentStatus { get; set; }
        public string Delivery { get; set; }  
    }
}
