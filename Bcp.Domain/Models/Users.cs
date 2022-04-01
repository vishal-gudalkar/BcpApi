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
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Dpt { get; set; }
        [Column(TypeName = "varchar(5)")]
        public string Werks { get; set; }
        [DefaultValue(0)]
        public int Transport { get; set; }
        public string Password { get; set; }
        public string Wc { get; set; }  
        public string FailedLogin { get; set; }
        [DefaultValue(0)]
        public int FailedLoginCount { get; set; }
    }
}
