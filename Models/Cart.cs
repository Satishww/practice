using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TruYumCaseStudyMVC.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; }
       
    }
}
