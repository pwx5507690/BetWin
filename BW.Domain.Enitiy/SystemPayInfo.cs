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
    public class SystemPayInfo : Base<SystemPayInfo>
    {
        [JsonProperty(PropertyName = "maxcoin")]
        [Column("MaxCoin", DbType.Int32)]
        public int MaxCoin { get; set; }

        [JsonProperty(PropertyName = "mincoin")]
        [Column("MinCoin", DbType.Int32)]
        public int MinCoin { get; set; }

        [JsonProperty(PropertyName = "merchantname")]
        [Column("MerchantName", DbType.String)]
        public string MerchantName { get; set; }

        [JsonProperty(PropertyName = "type")]
        [Column("Type", DbType.Int32)]
        public int Type { get; set; }

        [JsonProperty(PropertyName = "bankcardno")]
        [Column("bankCardNo", DbType.String)]
        public string bankCardNo { get; set; }

        [JsonProperty(PropertyName = "remarks")]
        [Column("Remarks", DbType.String)]
        public string Remarks { get; set; }

        [JsonProperty(PropertyName = "ptid")]
        [Column("PtID", DbType.Int32)]
        public int PtID { get; set; }

        [JsonProperty(PropertyName = "typecode")]
        [Column("TypeCode", DbType.String)]
        public string TypeCode { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Int32)]
        public int State { get; set; }

    }
}