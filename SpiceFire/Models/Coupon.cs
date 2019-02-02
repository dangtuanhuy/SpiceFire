using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpiceFire.Models
{
    public class Coupon
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Coupon can not null")]
        [Display(Name = "Coupon")]
        public string Name { get; set; }

        [Required(ErrorMessage = "CouponType can not null")]
        [Display(Name = "CouponType")]
        public string CouponType { get; set; }
        public enum ECouponType { Percent = 0, Dollar = 1}

        [Required(ErrorMessage ="Discount can not null")]
        [Display(Name = "Discount")]
        public double Discount { get; set; }

        [Required(ErrorMessage = "MinimumAmount can not null")]
        [Display(Name = "MinimumAmount")]
        public double MinimumAmount { get; set; }

        [Display(Name = "Picture")]
        public byte[] Picture { get; set; }

        public Boolean IsActive { get; set; }
    }
}
