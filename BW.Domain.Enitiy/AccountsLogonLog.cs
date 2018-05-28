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
    public class AccountsLogonLog : Base<AccountsLogonLog>
    {
        [JsonProperty(PropertyName = "userid")]
        [Column("UserID", DbType.Int32)]
        public int UserID { get; set; }

        [JsonProperty(PropertyName = "logonip")]
        [Column("LogonIP", DbType.String)]
        public string LogonIP { get; set; }

        [JsonProperty(PropertyName = "logondate")]
        [Column("LogonDate", DbType.DateTime)]
        public DateTime LogonDate { get; set; }

        [JsonProperty(PropertyName = "logontype")]
        [Column("LogonType", DbType.Int32)]
        public int LogonType { get; set; }

    }
}