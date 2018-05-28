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
    public class SystemBankType : Base<SystemBankType>
    {
        [JsonProperty(PropertyName = "bankID")]
        [Column("BankID", DbType.Int32)]
        public int BankID { get; set; }

        [JsonProperty(PropertyName = "bankName")]
        [Column("BankName", DbType.String)]
        public string BankName { get; set; }

        [JsonProperty(PropertyName = "bankIcoUrl")]
        [Column("BankIcoUrl", DbType.String)]
        public string BankIcoUrl { get; set; }

        [JsonProperty(PropertyName = "bankNumLen")]
        [Column("BankNumLen", DbType.Int32)]
        public int BankNumLen { get; set; }

        [JsonProperty(PropertyName = "bankCode")]
        [Column("BankCode", DbType.String)]
        public string BankCode { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Int32)]
        public int State { get; set; }
    }
}
