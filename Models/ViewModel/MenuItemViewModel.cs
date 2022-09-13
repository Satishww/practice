using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruYumCaseStudyMVC.Models
{
    public class MenuItemViewModel
    {
        public MenuItem MenuItem { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
