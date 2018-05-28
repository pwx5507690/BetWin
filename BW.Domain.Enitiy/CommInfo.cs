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
    public class CommInfo : Base<CommInfo>
    {
        [JsonProperty(PropertyName = "userid")]
        [Column("UserID", DbType.Int32)]
        public int UserID { get; set; }

        [JsonProperty(PropertyName = "accounts")]
        [Column("Accounts", DbType.String)]
        public string Accounts { get; set; }

        [JsonProperty(PropertyName = "periodnum")]
        [Column("PeriodNum", DbType.String)]
        public string PeriodNum { get; set; }

        [JsonProperty(PropertyName = "betcoin")]
        [Column("BetCoin", DbType.Decimal)]
        public decimal BetCoin { get; set; }

        [JsonProperty(PropertyName = "commcoin")]
        [Column("CommCoin", DbType.Decimal)]
        public decimal CommCoin { get; set; }

        [JsonProperty(PropertyName = "betcount")]
        [Column("BetCount", DbType.Int32)]
        public int BetCount { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Int32)]
        public int State { get; set; }

        [JsonProperty(PropertyName = "periodtype")]
        [Column("PeriodType", DbType.Int32)]
        public int PeriodType { get; set; }

        [JsonProperty(PropertyName = "add_date")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }

    }
}