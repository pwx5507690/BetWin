using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BW.App.Models
{
    public class OptionModel
    {
        [JsonProperty(PropertyName = "cmd")]
        public string Cmd { get; set; }
        [JsonProperty(PropertyName = "respository")]
        public string Respository { get; set; }
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
    }
}