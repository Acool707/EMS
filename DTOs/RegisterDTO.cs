using System;
using System.Collections.Generic;
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
        public DateTime DOB { get; set; }
        public string SSN { get; set; }
        public string UserType { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string WhatsappNumber { get; set; }
        public ICollection<MenuDTO> Menus { get; set; }
        public ICollection<WebsiteDTO> Websites { get; set; }
    }
}
