using System;

namespace EMS.DTOs
{
    public class UserInOutTimeDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime UserInTime { get; set; }
        public DateTime UserOutTime { get; set; }
    }
}