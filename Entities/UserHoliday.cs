using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace EMS.Entities
{
    public class UserHoliday
    {
        public int Id { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public DateTime HolidayDate { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}