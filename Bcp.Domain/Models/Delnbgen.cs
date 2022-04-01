using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bcp.Domain.Models
{
    public class Delnbgen
    {
        [Key]        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DelId { get; set; }
    }
}
