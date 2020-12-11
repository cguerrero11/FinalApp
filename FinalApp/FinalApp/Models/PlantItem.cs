using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FinalApp
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class PlantItem
    {
        [JsonProperty(PropertyName = "common_name")]
        public string commonName { get; set; }

        [JsonProperty(PropertyName = "scientific_name")]
        public string scientificName { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string imageURL { get; set; }


    }
}
