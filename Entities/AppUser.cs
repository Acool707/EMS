using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleNames { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string SSN { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string UserType { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string  PhoneNumber { get; set; }
        public string WhatsappNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public ICollection<Permission> Permissions { get; set; }
        public ICollection<Website> Websites { get; set; }
        public ICollection<UserHoliday> userHolidays { get; set; }
        public ICollection<UserInOutTime> userInOutTimes { get; set; }
        public ICollection<UserLeaveApplication> userLeaveApplications { get; set; }
    }
}
