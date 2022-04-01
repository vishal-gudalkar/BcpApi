using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bcp.Domain.Models
{
    public class ProdMovements
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string OrderNb { get; set; }
        public string WorkCenterPlan { get; set; }
        public string MatNr { get; set; }
        public string Master_Camp { get; set; }
        public int? Qty_To_Prod { get; set; }
        public string Work_Center { get; set; }
        public int? Net_Qty { get; set; }
        public int? Scrap { get; set; }
        public string TmStmp { get; set; }
        public string User { get; set; }
        public string Comment { get; set; }     
    }
}
