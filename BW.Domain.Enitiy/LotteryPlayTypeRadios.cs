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
    public class LotteryPlayTypeRadios : Base<LotteryPlayTypeRadios>
    {
        [JsonProperty(PropertyName = "playtyperadioname")]
        [Column("PlayTypeRadioName", DbType.String)]
        public string PlayTypeRadioName { get; set; }

        [JsonProperty(PropertyName = "maxbonus")]
        [Column("MaxBonus", DbType.Decimal)]
        public decimal MaxBonus { get; set; }

        [JsonProperty(PropertyName = "minbonus")]
        [Column("MinBonus", DbType.Decimal)]
        public decimal MinBonus { get; set; }

        [JsonProperty(PropertyName = "stepdata")]
        [Column("StepData", DbType.Decimal)]
        public decimal StepData { get; set; }

        [JsonProperty(PropertyName = "numcode")]
        [Column("NumCode", DbType.Int32)]
        public int NumCode { get; set; }

        [JsonProperty(PropertyName = "radiocode")]
        [Column("RadioCode", DbType.Int32)]
        public int RadioCode { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Boolean)]
        public bool State { get; set; }

        [JsonProperty(PropertyName = "occdate")]
        [Column("OccDate", DbType.DateTime)]
        public DateTime OccDate { get; set; }

    }
}