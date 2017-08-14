using System;
using System.ComponentModel.DataAnnotations;
namespace App.Entity.Models
{
    public class AgentInfo : BaseModel
    {
        [Required]
        [StringLength(20)]
        [Display(Name = "Agent Id")]
        public string AgentId { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "Office Name")]
        public string OfficeName { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "Agent Name")]
        public string AgentName { get; set; }

        [StringLength(50)]
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [StringLength(25)]
        [Display(Name = "Mobile No")]
        public string MobileNo { get; set; }

        [StringLength(255)]
        [Display(Name = "Office Address")]
        public string Address { get; set; }

        [StringLength(15)]
        [Display(Name = "Office No")]
        public string OfficeNo { get; set; }

        [StringLength(15)]
        [Display(Name = "Fax No")]
        public string FaxNo { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Username")]
        [System.Web.Mvc.Remote("IsUserExist","Account",HttpMethod = "POST",ErrorMessage = "Username already taken, try another.")]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int? ResetStatus { get; set; }

        [StringLength(10)]
        public string Channel { get; set; }

        [StringLength(30)]
        [Display(Name = "Agent Photo")]
        public string AgentPhoto { get; set; }

        public int Status { get; set; }
    }
}