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
    public class AccountsNews : Base<AccountsNews>
    {
        [JsonProperty(PropertyName = "userid")]
        [Column("UserID", DbType.String)]
        public string UserID { get; set; }

        [JsonProperty(PropertyName = "accounts")]
        [Column("Accounts", DbType.String)]
        public string Accounts { get; set; }

        [JsonProperty(PropertyName = "infotype")]
        [Column("InfoType", DbType.Int32)]
        public int InfoType { get; set; }

        [JsonProperty(PropertyName = "info")]
        [Column("Info", DbType.String)]
        public string Info { get; set; }

        [JsonProperty(PropertyName = "add_date")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }

    }
}