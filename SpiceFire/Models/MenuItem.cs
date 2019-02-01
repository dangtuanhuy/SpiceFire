using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpiceFire.Models
{
    public class MenuItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Menu Item can not null")]
        [Display(Name = "Menu Item")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Details can not null")]
        [Display(Name = "Details")]
        public string Description { get; set; }

        [Display(Name = "Spicyness")]
        public string Spicyness { get; set; }
        public enum ESpicy { NA = 0, NotSpice =1, Spicy = 2, VerySpice = 3 }

        [Display(Name = "Img")]
        public string Image { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Display(Name = "Sub Category")]
        public int SubCategoryId { get; set; }

        [Display(Name = "Price")]
        [Range(1,int.MaxValue,ErrorMessage ="Price should be greater than ${1}")]
        public double Price { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [ForeignKey("SubCategoryId")]
        public virtual SubCategory SubCategory { get; set; }

    }
}
