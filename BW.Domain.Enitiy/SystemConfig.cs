using BW.DataSource;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BW.Enitiy
{
    public class SystemConfig : Base<SystemConfig>
    {
        [JsonProperty(PropertyName = "configname")]
        [Column("ConfigName", DbType.String)]
        public string ConfigName { get; set; }

        [JsonProperty(PropertyName = "configtitle")]
        [Column("ConfigTitle", DbType.String)]
        public string ConfigTitle { get; set; }

        [JsonProperty(PropertyName = "configvalue")]
        [Column("ConfigValue", DbType.String)]
        public string ConfigValue { get; set; }
    }
}