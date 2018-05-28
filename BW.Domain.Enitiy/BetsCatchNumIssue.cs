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
    public class BetsCatchNumIssue : Base<BetsCatchNumIssue>
    {
        [JsonProperty(PropertyName = "catchnumcode")]
        [Column("CatchNumCode", DbType.String)]
        public string CatchNumCode { get; set; }

        [JsonProperty(PropertyName = "issuecode")]
        [Column("IssueCode", DbType.String)]
        public string IssueCode { get; set; }

        [JsonProperty(PropertyName = "catchnumissuecode")]
        [Column("CatchNumIssueCode", DbType.String)]
        public string CatchNumIssueCode { get; set; }

        [JsonProperty(PropertyName = "lotterycode")]
        [Column("LotteryCode", DbType.Int32)]
        public int LotteryCode { get; set; }

        [JsonProperty(PropertyName = "totalorder")]
        [Column("TotalOrder", DbType.Decimal)]
        public decimal TotalOrder { get; set; }

        [JsonProperty(PropertyName = "totalbetcount")]
        [Column("TotalBetCount", DbType.Int32)]
        public int TotalBetCount { get; set; }

        [JsonProperty(PropertyName = "catchnum")]
        [Column("CatchNum", DbType.Int32)]
        public int CatchNum { get; set; }

        [JsonProperty(PropertyName = "completenum")]
        [Column("CompleteNum", DbType.Int32)]
        public int CompleteNum { get; set; }

        [JsonProperty(PropertyName = "completecoin")]
        [Column("CompleteCoin", DbType.Decimal)]
        public decimal CompleteCoin { get; set; }

        [JsonProperty(PropertyName = "revocationcoin")]
        [Column("RevocationCoin", DbType.Decimal)]
        public decimal RevocationCoin { get; set; }

        [JsonProperty(PropertyName = "isstop")]
        [Column("IsStop", DbType.Int32)]
        public int IsStop { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Int32)]
        public int State { get; set; }

        [JsonProperty(PropertyName = "userid")]
        [Column("UserID", DbType.Int32)]
        public int UserID { get; set; }

        [JsonProperty(PropertyName = "accounts")]
        [Column("Accounts", DbType.String)]
        public string Accounts { get; set; }

    }
}