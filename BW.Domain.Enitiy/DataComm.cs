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
    public class DataComm : Base<DataComm>
    {
        [JsonProperty(PropertyName = "userid")]
        [Column("UserID", DbType.Int32)]
        public int UserID { get; set; }

        [JsonProperty(PropertyName = "accounts")]
        [Column("Accounts", DbType.String)]
        public string Accounts { get; set; }

        [JsonProperty(PropertyName = "betcount")]
        [Column("BetCount", DbType.Int32)]
        public int BetCount { get; set; }

        [JsonProperty(PropertyName = "betcoin")]
        [Column("BetCoin", DbType.Decimal)]
        public decimal BetCoin { get; set; }

        [JsonProperty(PropertyName = "comcion")]
        [Column("ComCion", DbType.Decimal)]
        public decimal ComCion { get; set; }

        [JsonProperty(PropertyName = "add_date")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }

        [JsonProperty(PropertyName = "timetype")]
        [Column("TimeType", DbType.Int32)]
        public int TimeType { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Int32)]
        public int State { get; set; }

        [JsonProperty(PropertyName = "code")]
        [Column("Code", DbType.String)]
        public string Code { get; set; }

    }
}