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
    public class AccountsBankInfo : Base<AccountsBankInfo>
    {
        [JsonProperty(PropertyName = "userID")]
        [Column("UserID", DbType.Int32)]
        public int UserID { get; set; }
        [JsonProperty(PropertyName = "accounts")]
        [Column("Accounts", DbType.String)]
        public string Accounts { get; set; }
        [JsonProperty(PropertyName = "bankName")]
        [Column("BankName", DbType.String)]
        public string BankName { get; set; }
        [JsonProperty(PropertyName = "bankCode")]
        [Column("BankCode", DbType.String)]
        public string BankCode { get; set; }
        [JsonProperty(PropertyName = "bankNum")]
        [Column("BankNum", DbType.String)]
        public string BankNum { get; set; }
        [JsonProperty(PropertyName = "bankAddress")]
        [Column("BankAddress", DbType.String)]
        public string BankAddress { get; set; }
        [JsonProperty(PropertyName = "bankUserName")]
        [Column("BankUserName", DbType.String)]
        public string BankUserName { get; set; }
        [JsonProperty(PropertyName = "addDate")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }
    }
}
