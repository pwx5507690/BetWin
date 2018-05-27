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
    public class AccountsCollection : Base<AccountsCollection>
    {
        [JsonProperty(PropertyName = "userID")]
        [Column("UserID", DbType.Int32)]
        public int UserID { get; set; }
        [JsonProperty(PropertyName = "lotteryCode")]
        [Column("LotteryCode", DbType.String)]
        public string LotteryCode { get; set; }
        [JsonProperty(PropertyName = "accounts")]
        [Column("Accounts", DbType.String)]
        public string Accounts { get; set; }
        [JsonProperty(PropertyName = "addDate")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }
    }
}
