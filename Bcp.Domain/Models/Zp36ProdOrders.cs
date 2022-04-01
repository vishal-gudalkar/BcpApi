using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bcp.Domain.Models
{
    public class Zp36ProdOrders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string OrderNb { get; set; }
        public string WorkCenterPlan { get; set; }
        public string MatNr { get; set; }
        public string PId { get; set; }
        [Column(TypeName = "varchar(5)")]
        public string Version { get; set; }
        public string MasterCamp { get; set; }
        public int? QtyToProd { get; set; }
        public string Operation { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string AdditionalData { get; set; }
        public string WorkCenter { get; set; }
        public int? NetQty { get; set; }
        public int? Scrap { get; set; }
        public string TmStmp { get; set; }
        public string User { get; set; }
        public string RackType { get; set; }  
    }
}
