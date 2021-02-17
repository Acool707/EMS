using EMS.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EMS.DTOs
{
    public class PermissionDTO
    {
        public int Id { get; set; }
        public int PermissionType { get; set; }
    }
}