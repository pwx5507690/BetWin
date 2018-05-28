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
    public class AccountsDataTotal : Base<AccountsDataTotal>
    {
        [JsonProperty(PropertyName = "userID")]
        [Column("UserID", DbType.Int32)]
        public int UserID { get; set; }

        [JsonProperty(PropertyName = "accounts")]
        [Column("Accounts", DbType.String)]
        public string Accounts { get; set; }

        [JsonProperty(PropertyName = "payTotal")]
        [Column("PayTotal", DbType.Decimal)]
        public decimal PayTotal { get; set; }

        [JsonProperty(PropertyName = "drawTotal")]
        [Column("DrawTotal", DbType.Decimal)]
        public decimal DrawTotal { get; set; }

        [JsonProperty(PropertyName = "betTotal")]
        [Column("BetTotal", DbType.Decimal)]
        public decimal BetTotal { get; set; }

        [JsonProperty(PropertyName = "activityTotal")]
        [Column("ActivityTotal", DbType.Decimal)]
        public decimal ActivityTotal { get; set; }

        [JsonProperty(PropertyName = "canBetTotal")]
        [Column("CanBetTotal", DbType.Decimal)]
        public decimal CanBetTotal { get; set; }
    }
}
