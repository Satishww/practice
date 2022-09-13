using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TruYumCaseStudyMVC.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field Price must be greater than or equal to 1")]
        [Range(1, double.MaxValue)]
        public double Price { get; set; }

        [Display(Name = "Free Delivery")]
        public bool FreeDelivery { get; set; }

        [Display(Name = "Date of Launch")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DateOfLaunch { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool Active { get; set; }
        public ICollection<Cart> Carts { get; set; }
    
}
}
