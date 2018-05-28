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
    public class SignLogs : Base<SignLogs>
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

    }
}