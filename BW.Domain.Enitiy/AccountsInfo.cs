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
    public class AccountsInfo : SQLDataEnity<AccountsInfo>
    {
        public AccountsInfo() : base("Connection")
        {

        }
        [JsonProperty(PropertyName = "userID")]
        [Column("UserID", DbType.Int32, ident: true, key: true)]
        public int UserID { get; set; }

        [JsonProperty(PropertyName = "accounts")]
        [Column("Accounts", DbType.String)]
        public string Accounts { get; set; }

        [JsonProperty(PropertyName = "nickName")]
        [Column("NickName", DbType.String)]
        public string NickName { get; set; }

        [JsonProperty(PropertyName = "compellation")]
        [Column("Compellation", DbType.String)]
        public string Compellation { get; set; }

        [JsonProperty(PropertyName = "logonPass")]
        [Column("LogonPass", DbType.String)]
        public string LogonPass { get; set; }

        [JsonProperty(PropertyName = "insurePass")]
        [Column("InsurePass", DbType.String)]
        public string InsurePass { get; set; }

        [JsonProperty(PropertyName = "nullity")]
        [Column("Nullity", DbType.Int32)]
        public int Nullity { get; set; }

        [JsonProperty(PropertyName = "nullityOverDate")]
        [Column("NullityOverDate", DbType.DateTime)]
        public DateTime NullityOverDate { get; set; }

        [JsonProperty(PropertyName = "logonTimes")]
        [Column("LogonTimes", DbType.Int32)]
        public int LogonTimes { get; set; }

        [JsonProperty(PropertyName = "lastLogonIP")]
        [Column("LastLogonIP", DbType.String)]
        public string LastLogonIP { get; set; }

        [JsonProperty(PropertyName = "lastLogonDate")]
        [Column("LastLogonDate", DbType.DateTime)]
        public DateTime LastLogonDate { get; set; }

        [JsonProperty(PropertyName = "registerIP")]
        [Column("RegisterIP", DbType.String)]
        public string RegisterIP { get; set; }

        [JsonProperty(PropertyName = "registerDate")]
        [Column("RegisterDate", DbType.DateTime)]
        public DateTime RegisterDate { get; set; }

        [JsonProperty(PropertyName = "userType")]
        [Column("UserType", DbType.Int32)]
        public int UserType { get; set; }

        [JsonProperty(PropertyName = "parentID")]
        [Column("ParentID", DbType.Int32)]
        public int ParentID { get; set; }

        [JsonProperty(PropertyName = "rebate")]
        [Column("Rebate", DbType.Int32)]
        public int Rebate { get; set; }

        [JsonProperty(PropertyName = "userRight")]
        [Column("UserRight", DbType.String)]
        public string UserRight { get; set; }

        [JsonProperty(PropertyName = "userLayer")]
        [Column("UserLayer", DbType.Int32)]
        public int UserLayer { get; set; }

        [JsonProperty(PropertyName = "isDemo")]
        [Column("IsDemo", DbType.Int32)]
        public int IsDemo { get; set; }

        [JsonProperty(PropertyName = "coin")]
        [Column("Coin", DbType.Decimal)]
        public decimal Coin { get; set; }

        [JsonProperty(PropertyName = "codeCoin")]
        [Column("CodeCoin", DbType.Decimal)]
        public decimal CodeCoin { get; set; }

        [JsonProperty(PropertyName = "compCodeCoin")]
        [Column("CompCodeCoin", DbType.Decimal)]
        public decimal CompCodeCoin { get; set; }

        [JsonProperty(PropertyName = "score")]
        [Column("Score", DbType.Decimal)]
        public decimal Score { get; set; }

        [JsonProperty(PropertyName = "scoreTotal")]
        [Column("ScoreTotal", DbType.Decimal)]
        public decimal ScoreTotal { get; set; }

        [JsonProperty(PropertyName = "signCount")]
        [Column("SignCount", DbType.Int32)]
        public int SignCount { get; set; }

        [JsonProperty(PropertyName = "oLType")]
        [Column("OLType", DbType.Int32)]
        public int OLType { get; set; }

        [JsonProperty(PropertyName = "oLState")]
        [Column("OLState", DbType.Int32)]
        public int OLState { get; set; }

        [JsonProperty(PropertyName = "bankFlag")]
        [Column("BankFlag", DbType.Int32)]
        public int BankFlag { get; set; }

        [JsonProperty(PropertyName = "parentStr")]
        [Column("ParentStr", DbType.String)]
        public string ParentStr { get; set; }

        [JsonProperty(PropertyName = "regFrom")]
        [Column("RegFrom", DbType.Int32)]
        public int RegFrom { get; set; }
    }
}
