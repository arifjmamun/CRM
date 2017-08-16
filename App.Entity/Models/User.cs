using System.ComponentModel.DataAnnotations;

namespace App.Entity.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Uid { get; set; }

        [Required]
        [StringLength(45)]
        public string IpAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        public long CreatedOn { get; set; }

        public long? LastLogin { get; set; }

        public Status? Active { get; set; }

        [StringLength(20)]
        public string EmployeeId { get; set; }

        [StringLength(20)]
        public string BranchId { get; set; }

        [Required]
        [StringLength(20)]
        public string Level { get; set; }
    }
}