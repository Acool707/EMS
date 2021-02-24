using Newtonsoft.Json;

namespace EMS.DTOs
{
    public class MenuDTO
    {
        [JsonProperty(PropertyName = "item_id")]
        public int item_id { get; set; }
        [JsonProperty(PropertyName = "item_text")]
        public string item_text { get; set; }
    }
}