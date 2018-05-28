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
    public class SystemCashConfig : Base<SystemCashConfig>
    {
        [JsonProperty(PropertyName = "cashtype")]
        [Column("CashType", DbType.Int32)]
        public int CashType { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Int32)]
        public int State { get; set; }

        [JsonProperty(PropertyName = "cashclinttype")]
        [Column("CashClintType", DbType.Int32)]
        public int CashClintType { get; set; }

        [JsonProperty(PropertyName = "payname")]
        [Column("PayName", DbType.String)]
        public string PayName { get; set; }

        [JsonProperty(PropertyName = "payaccount")]
        [Column("PayAccount", DbType.String)]
        public string PayAccount { get; set; }

        [JsonProperty(PropertyName = "paykey")]
        [Column("PayKey", DbType.String)]
        public string PayKey { get; set; }

        [JsonProperty(PropertyName = "paycallurl")]
        [Column("PayCallUrl", DbType.String)]
        public string PayCallUrl { get; set; }

        [JsonProperty(PropertyName = "payinfo")]
        [Column("PayInfo", DbType.String)]
        public string PayInfo { get; set; }

        [JsonProperty(PropertyName = "payclintinfo")]
        [Column("PayClintInfo", DbType.String)]
        public string PayClintInfo { get; set; }

        [JsonProperty(PropertyName = "sort")]
        [Column("Sort", DbType.Int32)]
        public int Sort { get; set; }

        [JsonProperty(PropertyName = "minpay")]
        [Column("MinPay", DbType.Decimal)]
        public decimal MinPay { get; set; }

        [JsonProperty(PropertyName = "maxpay")]
        [Column("MaxPay", DbType.Decimal)]
        public decimal MaxPay { get; set; }

        [JsonProperty(PropertyName = "noteinfo")]
        [Column("NoteInfo", DbType.String)]
        public string NoteInfo { get; set; }

    }
}