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
    public class AccountsInvitel : Base<AccountsInvitel>
    {
        [JsonProperty(PropertyName = "userid")]
        [Column("UserID", DbType.Int32)]
        public int UserID { get; set; }

        [JsonProperty(PropertyName = "accounts")]
        [Column("Accounts", DbType.String)]
        public string Accounts { get; set; }

        [JsonProperty(PropertyName = "add_date")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }

        [JsonProperty(PropertyName = "codestr")]
        [Column("CodeStr", DbType.String)]
        public string CodeStr { get; set; }

        [JsonProperty(PropertyName = "rebate")]
        [Column("Rebate", DbType.Int32)]
        public int Rebate { get; set; }

        [JsonProperty(PropertyName = "usertype")]
        [Column("UserType", DbType.Int32)]
        public int UserType { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Int32)]
        public int State { get; set; }

        [JsonProperty(PropertyName = "up_date")]
        [Column("Up_Date", DbType.DateTime)]
        public DateTime Up_Date { get; set; }

        [JsonProperty(PropertyName = "parentstr")]
        [Column("ParentStr", DbType.String)]
        public string ParentStr { get; set; }

    }
}