using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Northwind.MVC5App.ViewModels
{
    public class CreateEmployeeViewModel
    { 
        [Display(Name ="Last Name")]
        [Required(ErrorMessage ="You must supply Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You must supply First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Job Title")]
        [Required(ErrorMessage = "You must supply a Title")]
        public string Title { get; set; }

        [Display(Name = "Home Phone")]
        [Required(ErrorMessage = "You must supply a Home Phone")]
        public string HomePhone { get; set; }

        [Display(Name = "Hire Date")]
        [Required(ErrorMessage = "You must supply a Hire Date")]
        public DateTime HireDate { get; set; }
    }
}
