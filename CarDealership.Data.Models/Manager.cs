using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Data.Models
{
    using static CarDealership.Common.Constants.ManagerValidations;

    public class Manager
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(PhoneNumberMinLength)]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;
    }
}
