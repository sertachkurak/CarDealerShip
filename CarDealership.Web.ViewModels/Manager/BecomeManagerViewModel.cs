using System.ComponentModel.DataAnnotations;

namespace CarDealership.Web.ViewModels.Manager
{
    using static Common.Constants.ManagerValidations;

    public class BecomeManagerViewModel
    {
        [Required]
        [MinLength(FirstNameMinLength)]
        [MaxLength(FirstNameMaxLength)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MinLength(PhoneNumberMinLength)]
        [MaxLength(PhoneNumberMaxLength)]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } = null!;
    }
}
