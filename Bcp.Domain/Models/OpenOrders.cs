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
    public class OpenOrders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [Column(TypeName = "varchar(5)")]
        public string SOrg { get; set; }       
        public string SalesDoc { get; set; }        
        public int Item { get; set; }      
        public int OrderNb { get; set; }
        [DefaultValue("-")]
        public string CustOrderNb { get; set; }
        public string SaTy { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string DChl { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string Plnt { get; set; }
        public int? SoldToPt { get; set; }
        public string SoldToName { get; set; }
        public int? ShipTo { get; set; }
        public string ShipToName { get; set; }
        public string Material { get; set; }
        public string CustMaterial { get; set; }
        public DateTime? MatAvDt { get; set; }
        public int? OpenQty { get; set; }
        public decimal? PriceSo { get; set; }
        [Column(TypeName = "varchar(5)")]
        public string Curr { get; set; }
        public int? Division { get; set; }
        public string Name { get; set; }
        [DefaultValue(0)]
        public int ShipQty { get; set; }
        [DefaultValue("")]
        public string PlanOrder { get; set; }
        public int? PlanOrderQty { get; set; }
        public string Sloc { get; set; }
    
    }
}
