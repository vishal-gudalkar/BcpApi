using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bcp.Domain.Models
{
    public class Routing
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Column(TypeName = "varchar(5)")]
        public string Plant { get; set; }
        public string ConsolidatedCode { get; set; }
        public string Material { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string MaterialType { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string Operation { get; set; }
        public string WorkCenter { get; set; }
        public string Description { get; set; }
        public int? Stufe { get; set; }
    }
}
