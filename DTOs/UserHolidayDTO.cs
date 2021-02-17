using Newtonsoft.Json.Converters;
using System;
using System.Text.Json.Serialization;

namespace EMS.DTOs
{
    public class UserHolidayDTO
    {
        public int Id { get; set; }
        public DateTime HolidayDate { get; set; }
    }
}