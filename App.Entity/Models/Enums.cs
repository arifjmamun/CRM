using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.Entity.Models
{
    public enum Status
    {
        [Display(Name = "Inactive"), Description("Inactive")]
        Inactive,
        [Display(Name = "Active"), Description("Active")]
        Active
    }

    public enum WorkingStatus
    {
        Pending,
        Done
    }

    public enum DeliveryStatus
    {
        [Display(Name = "Not Delivery")]
        NotDelivery,
        [Display(Name = "Delivery")]
        Delivery
    }

    public enum InformationUpdate
    {
        [Display(Name = "Not Updated")]
        NotUpdated,
        [Display(Name = "Updated")]
        Updated
    }

    public enum SmsConfirmation
    {
        [Display(Name = "Not Sending SMS")]
        NotSendingSms,
        [Display(Name = "Sending SMS")]
        SendingSms
    }

    public enum RequireSuppiler
    {
        No,
        Yes
    }

    public enum ReferralsType
    {
        Agent=1,
        Referrals=2,
        Office=3
    }

    public enum UserType
    {
        IsAgent,
        IsAdmin
    }

    public enum Channel
    {
        IsCustomer = 1,
        IsAgent = 2,
        IsSupplier = 3
    }

    public enum TransactionType
    {
        Transfer=1,
        Deposit=2,
        Expense=3
    }

    public enum PayerType
    {
        Agent=1,
        Client=2,
        Officer=3,
        Other=4
    }

    public enum BalanceMode
    {
        Increment,
        Decrement
    }
}