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
    public class SystemNews : Base<SystemNews>
    {
        [JsonProperty(PropertyName = "contentinfo")]
        [Column("ContentInfo", DbType.String)]
        public string ContentInfo { get; set; }

        [JsonProperty(PropertyName = "add_date")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("state", DbType.Int32)]
        public int state { get; set; }
    }
}