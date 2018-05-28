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
    public class Bets : Base<Bets>
    {
        [JsonProperty(PropertyName = "issuecode")]
        [Column("IssueCode", DbType.String)]
        public string IssueCode { get; set; }

        [JsonProperty(PropertyName = "betcode")]
        [Column("BetCode", DbType.String)]
        public string BetCode { get; set; }

        [JsonProperty(PropertyName = "userid")]
        [Column("UserID", DbType.Int32)]
        public int UserID { get; set; }

        [JsonProperty(PropertyName = "accounts")]
        [Column("Accounts", DbType.String)]
        public string Accounts { get; set; }

        [JsonProperty(PropertyName = "betcount")]
        [Column("BetCount", DbType.Int32)]
        public int BetCount { get; set; }

        [JsonProperty(PropertyName = "totalcoin")]
        [Column("TotalCoin", DbType.Decimal)]
        public decimal TotalCoin { get; set; }

        [JsonProperty(PropertyName = "palyradiocode")]
        [Column("PalyRadioCode", DbType.Int32)]
        public int PalyRadioCode { get; set; }

        [JsonProperty(PropertyName = "multiple")]
        [Column("Multiple", DbType.Int32)]
        public int Multiple { get; set; }

        [JsonProperty(PropertyName = "model")]
        [Column("Model", DbType.Int32)]
        public int Model { get; set; }

        [JsonProperty(PropertyName = "prizetype")]
        [Column("PrizeType", DbType.Int32)]
        public int PrizeType { get; set; }

        [JsonProperty(PropertyName = "return")]
        [Column("Return", DbType.Decimal)]
        public decimal Return { get; set; }

        [JsonProperty(PropertyName = "betcontent")]
        [Column("BetContent", DbType.String)]
        public string BetContent { get; set; }

        [JsonProperty(PropertyName = "winmoney")]
        [Column("WinMoney", DbType.Decimal)]
        public decimal WinMoney { get; set; }

        [JsonProperty(PropertyName = "wincount")]
        [Column("WinCount", DbType.Int32)]
        public int WinCount { get; set; }

        [JsonProperty(PropertyName = "openresult")]
        [Column("OpenResult", DbType.String)]
        public string OpenResult { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Int32)]
        public int State { get; set; }

        [JsonProperty(PropertyName = "add_date")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }

        [JsonProperty(PropertyName = "lotterycode")]
        [Column("LotteryCode", DbType.String)]
        public string LotteryCode { get; set; }

        [JsonProperty(PropertyName = "orderfrom")]
        [Column("OrderFrom", DbType.Int32)]
        public int OrderFrom { get; set; }

        [JsonProperty(PropertyName = "ordertype")]
        [Column("OrderType", DbType.Int32)]
        public int OrderType { get; set; }

        [JsonProperty(PropertyName = "catchnumcode")]
        [Column("CatchNumCode", DbType.String)]
        public string CatchNumCode { get; set; }

        [JsonProperty(PropertyName = "ismatch")]
        [Column("IsMatch", DbType.Boolean)]
        public bool IsMatch { get; set; }

    }
}