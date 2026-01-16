using System.ComponentModel.DataAnnotations;

namespace MVC_demo.Models
{
    public class Registration
    {
        [Required (ErrorMessage="Name is required")]
        public string Name { get; set; }


        [Required, EmailAddress]
        public string Email { get; set; }


        [Required,MinLength(8)]
        public string Password { get; set; }
    }
}
