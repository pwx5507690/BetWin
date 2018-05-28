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
    public class lotteryPlayTypeNums : Base<lotteryPlayTypeNums>
    {
        [JsonProperty(PropertyName = "playtypenumname")]
        [Column("PlayTypeNumName", DbType.String)]
        public string PlayTypeNumName { get; set; }

        [JsonProperty(PropertyName = "playcode")]
        [Column("PlayCode", DbType.Int32)]
        public int PlayCode { get; set; }

        [JsonProperty(PropertyName = "numcode")]
        [Column("NumCode", DbType.Int32)]
        public int NumCode { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Boolean)]
        public bool State { get; set; }

        [JsonProperty(PropertyName = "occdate")]
        [Column("OccDate", DbType.DateTime)]
        public DateTime OccDate { get; set; }

    }
}