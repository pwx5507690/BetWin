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
    public class AccountsNameTe : Base<AccountsNameTe>
    {
        [JsonProperty(PropertyName = "compellation")]
        [Column("Compellation", DbType.String)]
        public string Compellation { get; set; }

        [JsonProperty(PropertyName = "newcompellation")]
        [Column("NewCompellation", DbType.String)]
        public string NewCompellation { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Int32)]
        public int State { get; set; }

        [JsonProperty(PropertyName = "add_date")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }

        [JsonProperty(PropertyName = "up_date")]
        [Column("Up_Date", DbType.DateTime)]
        public DateTime Up_Date { get; set; }

        [JsonProperty(PropertyName = "userid")]
        [Column("UserID", DbType.Int32)]
        public int UserID { get; set; }

        [JsonProperty(PropertyName = "accounts")]
        [Column("Accounts", DbType.String)]
        public string Accounts { get; set; }

    }
}