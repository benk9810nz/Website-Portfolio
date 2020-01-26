using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsitePortfolio.Models
{
    public class ContactFormModel
    {
        [Key]
        public int ContactID { get; set; }

        [Required(ErrorMessage = "Please enter a Name")]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter an Email Address")]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a Message")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
   }
}
