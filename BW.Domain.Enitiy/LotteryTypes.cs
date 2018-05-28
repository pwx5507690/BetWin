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
    public class LotteryTypes : Base<LotteryTypes>
    {
        [JsonProperty(PropertyName = "lotteryname")]
        [Column("LotteryName", DbType.String)]
        public string LotteryName { get; set; }

        [JsonProperty(PropertyName = "lotterycode")]
        [Column("LotteryCode", DbType.String)]
        public string LotteryCode { get; set; }

        [JsonProperty(PropertyName = "icongrayurl")]
        [Column("IconGrayUrl", DbType.String)]
        public string IconGrayUrl { get; set; }

        [JsonProperty(PropertyName = "iconurl")]
        [Column("IconUrl", DbType.String)]
        public string IconUrl { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Boolean)]
        public bool State { get; set; }

        [JsonProperty(PropertyName = "occdate")]
        [Column("OccDate", DbType.DateTime)]
        public DateTime OccDate { get; set; }

        [JsonProperty(PropertyName = "sort")]
        [Column("Sort", DbType.Int32)]
        public int Sort { get; set; }

        [JsonProperty(PropertyName = "groupname")]
        [Column("GroupName", DbType.String)]
        public string GroupName { get; set; }

        [JsonProperty(PropertyName = "guideurl")]
        [Column("GuideUrl", DbType.String)]
        public string GuideUrl { get; set; }

        [JsonProperty(PropertyName = "hot")]
        [Column("Hot", DbType.Int32)]
        public int Hot { get; set; }

        [JsonProperty(PropertyName = "rec")]
        [Column("Rec", DbType.Int32)]
        public int Rec { get; set; }

        [JsonProperty(PropertyName = "description")]
        [Column("Description", DbType.String)]
        public string Description { get; set; }

    }
}