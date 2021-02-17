using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EMS.Entities
{
    public class Website
    {
        public int Id { get; set; }
        public int WebsiteType { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }

    //public enum WebsiteType
    //{
    //    CRM = 1,
    //    DGS3 = 2,
    //    PS = 3,
    //    TS = 4
    //}
}