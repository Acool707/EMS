using System.ComponentModel.DataAnnotations;

namespace EMS.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength =4)]
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string LastName { get; set; }
        [Required]
        public string UserType { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Location { get; set; }
    }
}
