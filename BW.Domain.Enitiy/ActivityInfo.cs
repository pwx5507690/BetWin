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
    public class ActivityInfo : Base<ActivityInfo>
    {
        [JsonProperty(PropertyName = "bannerimageurl")]
        [Column("BannerImageUrl", DbType.String)]
        public string BannerImageUrl { get; set; }

        [JsonProperty(PropertyName = "sort")]
        [Column("Sort", DbType.Int32)]
        public int Sort { get; set; }

        [JsonProperty(PropertyName = "userclickurl")]
        [Column("userClickUrl", DbType.String)]
        public string userClickUrl { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("state", DbType.Int32)]
        public int state { get; set; }

    }
}