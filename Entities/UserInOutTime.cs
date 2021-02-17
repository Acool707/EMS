using System;

namespace EMS.Entities
{
    public class UserInOutTime
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public DateTime UserInTime { get; set; }
        public DateTime UserOutTime { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}