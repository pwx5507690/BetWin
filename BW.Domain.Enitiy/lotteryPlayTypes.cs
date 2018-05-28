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
    public class lotteryPlayTypes : Base<lotteryPlayTypes>
    {
        [JsonProperty(PropertyName = "playtypename")]
        [Column("PlayTypeName", DbType.String)]
        public string PlayTypeName { get; set; }

        [JsonProperty(PropertyName = "lotterycode")]
        [Column("LotteryCode", DbType.String)]
        public string LotteryCode { get; set; }

        [JsonProperty(PropertyName = "playcode")]
        [Column("PlayCode", DbType.Int32)]
        public int PlayCode { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Boolean)]
        public bool State { get; set; }

        [JsonProperty(PropertyName = "occdate")]
        [Column("OccDate", DbType.DateTime)]
        public DateTime OccDate { get; set; }

        [JsonProperty(PropertyName = "groupname")]
        [Column("GroupName", DbType.String)]
        public string GroupName { get; set; }

        [JsonProperty(PropertyName = "isdefault")]
        [Column("IsDefault", DbType.Boolean)]
        public bool IsDefault { get; set; }

        [JsonProperty(PropertyName = "isnew")]
        [Column("IsNew", DbType.Boolean)]
        public bool IsNew { get; set; }

    }
}