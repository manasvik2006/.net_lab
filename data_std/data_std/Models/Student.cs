using System.ComponentModel.DataAnnotations;

namespace data_std.Models
{
    public class Student
    {
        public int Usn { get; set; }
        [Required]
        [MaxLength(255)]

        public string FullName { get; set; }=string.Empty;
        [Required]
        [EmailAddress]

        public string Email { get; set; }=string.Empty;
        public string Department { get; set; }=string.Empty;
        public Address? Address { get; set; }
    }
}
