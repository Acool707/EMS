using EMS.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EMS.DTOs
{
    public class WebsiteDTO
    {
        [JsonProperty(PropertyName = "item_id")]
        public int item_id { get; set; }
        [JsonProperty(PropertyName = "item_text")]
        public string item_text { get; set; }
    }
}