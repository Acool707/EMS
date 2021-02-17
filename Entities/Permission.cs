using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EMS.Entities
{
    public class Permission
    {
        public int Id { get; set; }
        public int PermissionType { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }

//    public enum PermissionType
//    {
//        Add_Modify =1,
//        Delete = 2,
//        View =3
//    }
}