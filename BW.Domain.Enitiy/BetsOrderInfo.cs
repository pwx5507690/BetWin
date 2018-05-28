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
    public class BetsOrderInfo : Base<BetsOrderInfo>
    {
        [JsonProperty(PropertyName = "betcode")]
        [Column("BetCode", DbType.String)]
        public string BetCode { get; set; }

        [JsonProperty(PropertyName = "lotterycode")]
        [Column("LotteryCode", DbType.String)]
        public string LotteryCode { get; set; }

        [JsonProperty(PropertyName = "add_date")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Int32)]
        public int State { get; set; }

        [JsonProperty(PropertyName = "issuecode")]
        [Column("IssueCode", DbType.String)]
        public string IssueCode { get; set; }

        [JsonProperty(PropertyName = "totalorder")]
        [Column("TotalOrder", DbType.Decimal)]
        public decimal TotalOrder { get; set; }

        [JsonProperty(PropertyName = "totalbetcount")]
        [Column("TotalBetCount", DbType.Int32)]
        public int TotalBetCount { get; set; }

        [JsonProperty(PropertyName = "ordertype")]
        [Column("OrderType", DbType.Int32)]
        public int OrderType { get; set; }

        [JsonProperty(PropertyName = "userid")]
        [Column("UserID", DbType.Int32)]
        public int UserID { get; set; }

        [JsonProperty(PropertyName = "accounts")]
        [Column("Accounts", DbType.String)]
        public string Accounts { get; set; }

    }
}