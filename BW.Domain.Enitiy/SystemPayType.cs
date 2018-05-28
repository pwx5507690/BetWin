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
    public class SystemPayType : Base<SystemPayType>
    {
        [JsonProperty(PropertyName = "merchant")]
        [Column("Merchant", DbType.String)]
        public string Merchant { get; set; }

        [JsonProperty(PropertyName = "mernumber")]
        [Column("MerNumber", DbType.String)]
        public string MerNumber { get; set; }

        [JsonProperty(PropertyName = "merpublickey")]
        [Column("Merpublickey", DbType.String)]
        public string Merpublickey { get; set; }

        [JsonProperty(PropertyName = "merpublicparvitekey")]
        [Column("MerpublicParvitekey", DbType.String)]
        public string MerpublicParvitekey { get; set; }

        [JsonProperty(PropertyName = "zfnotifyurl")]
        [Column("ZFnotifyUrl", DbType.String)]
        public string ZFnotifyUrl { get; set; }

        [JsonProperty(PropertyName = "zfreturnurlp")]
        [Column("ZFreturnurlP", DbType.String)]
        public string ZFreturnurlP { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Int32)]
        public int State { get; set; }

        [JsonProperty(PropertyName = "add_date")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }
    }
}