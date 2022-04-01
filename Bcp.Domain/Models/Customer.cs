using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bcp.Domain.Models
{
    public class customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? Customer { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string SOrg { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string DChl { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string Dv { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string Funct { get; set; }
        public int? Customer1 { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Cty { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string IncoT { get; set; }
        public string Inco2 { get; set; }
        public string Curr { get; set; }
        public string SGrp { get; set; }
        public string Telephone1 { get; set; }
        public string FaxNumber { get; set; }
        public string TaxNumber1 { get; set; }
        public string TaxNumber2 { get; set; }

        [Column(name: "E-MailAddress")]
        public string EMailAddress { get; set; }
        public string CustomerBrand { get; set; }
        public string SiteName { get; set; }
        public string CustomerWebsite { get; set; }
        public string IdLogin { get; set; }
        public string IdPassword { get; set; }
        public string CustomerContactEmail1 { get; set; }
        public string CustomerContactEmail2 { get; set; }
        public string CustomerContactEmail3 { get; set; }
        public string CustomerEmergencyEmail { get; set; }
        public string CustomerAdditionalTelephone { get; set; }
        public string CustomerLogisticContactEmail { get; set; }
        public string CustomerTransportWebsite { get; set; }
        public string SGSCustomerServiceReferentEmail { get; set; }
        public string AcctAtCust { get; set; }     
    
    }
}
