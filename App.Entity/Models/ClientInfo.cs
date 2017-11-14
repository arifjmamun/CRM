using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Entity.Models
{
    public class ClientInfo
    {
        public ClientInfo()
        {
            NewFlightDate = DateTime.Now;
        }
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Customer Id")]
        public string CustomerId { get; set; }

        [Display(Name = "Branch")]
        [ForeignKey("BranchInfo")]
        public int? BranchId { get; set; }

        [StringLength(255)]
        public string Sn { get; set; }

        [Display(Name = "Referral Type")]
        public ReferralsType ReferralType { get; set; }

        [Display(Name = "Agent")]
        [ForeignKey("AgentInfo")]
        public int? AgentId { get; set; }

        [Display(Name = "Supplier")]
        [ForeignKey("SuppliersInfo")]
        public int? SupplierId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Pax First Name")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "Pax Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string FullName { get; set; }

        [StringLength(25, MinimumLength = 13, ErrorMessage = "Valid contact number range 13 and 25 characters.")]
        [Display(Name = "Pax Contact No")]
        public string ContactNo { get; set; }

        [StringLength(100)]
        public string Referral { get; set; }

        [StringLength(25)]
        [Display(Name = "Referral Contact No")]
        public string ReferralContactNo { get; set; }

        [Display(Name = "Service")]
        [ForeignKey("ServiceInfo")]
        public int ServiceId { get; set; }

        [Display(Name = "Air Line")]
        [ForeignKey("AirLineInfo")]
        public int? AirLineId { get; set; }

        [Display(Name = "Old Flight Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? OldFlightDate { get; set; }

        [Display(Name = "Change Flight Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? ChangeFlightDate { get; set; }

        [StringLength(50)]
        [Display(Name = "Air Line PNR")]
        public string AirLinePnr { get; set; }

        [StringLength(50)]
        [Display(Name = "GDS PNR")]
        public string GdsPnr { get; set; }

        [Display(Name = "New Flight Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime NewFlightDate { get; set; }

        [StringLength(150)]
        [Display(Name = "College Name")]
        public string CollageName { get; set; }

        [StringLength(150)]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [StringLength(100)]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Service Charge")]
        [Range(0.00,double.MaxValue,ErrorMessage = "Enter a positive value.")]
        public double? ServiceCharge { get; set; }

        [Range(0.00, double.MaxValue, ErrorMessage = "Enter a positive value.")]
        public double? Cost { get; set; }

        public double? Profit { get; set; }

        public double Discount { get; set; }

        [Display(Name = "Served By")]
        [ForeignKey("UserServedBy")]
        public int ServedBy { get; set; }

        [StringLength(100)]
        [Display(Name = "Flight Time")]
        public string DoneBy { get; set; }

        [Display(Name = "Working Status")]
        public WorkingStatus? WorkingStatus { get; set; }

        [Display(Name = "Delivery Status")]
        public DeliveryStatus? DeliveryStatus { get; set; }

        [Display(Name = "Information Update")]
        public InformationUpdate? InfoStatus { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }

        public Status? Status { get; set; }

        [Display(Name = "Delete Status")]
        public bool? DelStatus { get; set; }

        [Display(Name = "Entry By")]
        [ForeignKey("UserEntryBy")]
        public int EntryBy { get; set; }

        [Display(Name = "Entry Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime EntryDate { get; set; }

        [Display(Name = "Venue From")]
        [ForeignKey("SectorFrom")]
        public int? VenueFromId { get; set; }
        
        [Display(Name = "Venue To")]
        [ForeignKey("SectorTo")]
        public int? VenueToId { get; set; }

        [StringLength(25)]
        [Display(Name = "SMS Number")]
        public string SmsNo { get; set; }

        [Display(Name = "Country")]
        [ForeignKey("CountryList")]
        public int? CountryId { get; set; }

        [StringLength(10)]
        public string Finger { get; set; }

        [StringLength(10)]
        public string Manpower { get; set; }

        [Display(Name = "Ticket Issue")]
        [StringLength(10)]
        public string TicketIssue { get; set; }

        [Display(Name = "Flight Status")]
        [StringLength(10)]
        public string FlightStatus { get; set; }

        [Display(Name = "SMS Send Confirm")]
        public SmsConfirmation? SmsConfirmation { get; set; }

        public virtual AgentInfo AgentInfo { get; set; }
        public virtual User UserServedBy { get; set; }
        public virtual User UserEntryBy { get; set; }
        public virtual BranchInfo BranchInfo { get; set; }
        public virtual SectorInfo SectorFrom { get; set; }
        public virtual SectorInfo SectorTo { get; set; }
        public virtual CountryList CountryList { get; set; }
        public virtual AirLineInfo AirLineInfo { get; set; }
        public virtual SuppliersInfo SuppliersInfo { get; set; }
        public virtual ServiceInfo ServiceInfo { get; set; }
    }
}