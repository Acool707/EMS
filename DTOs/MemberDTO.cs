using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.DTOs
{
    public class MemberDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string FirstName { get; set; }
        public string MiddleNames { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public ICollection<MenuDTO> Menus { get; set; }
        public ICollection<PermissionDTO> Permissions { get; set; }
        public ICollection<WebsiteDTO> Websites { get; set; }
        public ICollection<UserHolidayDTO> userHolidays { get; set; }
        public ICollection<UserInOutTimeDTO> userInOutTimes { get; set; }
        public ICollection<UserLeaveApplicationDTO> userLeaveApplications { get; set; }
    }
}
