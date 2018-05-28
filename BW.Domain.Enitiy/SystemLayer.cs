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
    public class SystemLayer : Base<SystemLayer>
    {
        [JsonProperty(PropertyName = "layername")]
        [Column("LayerName", DbType.String)]
        public string LayerName { get; set; }

        [JsonProperty(PropertyName = "add_date")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }

        [JsonProperty(PropertyName = "up_date")]
        [Column("Up_Date", DbType.DateTime)]
        public DateTime Up_Date { get; set; }

        [JsonProperty(PropertyName = "mindeposittotal")]
        [Column("MinDepositTotal", DbType.Decimal)]
        public decimal MinDepositTotal { get; set; }

        [JsonProperty(PropertyName = "mindepositnum")]
        [Column("MinDepositNum", DbType.Int32)]
        public int MinDepositNum { get; set; }

        [JsonProperty(PropertyName = "minsingledeposit")]
        [Column("MinSingleDeposit", DbType.Decimal)]
        public decimal MinSingleDeposit { get; set; }

        [JsonProperty(PropertyName = "mindrawtotal")]
        [Column("MinDrawTotal", DbType.Decimal)]
        public decimal MinDrawTotal { get; set; }

        [JsonProperty(PropertyName = "mindarwnum")]
        [Column("MinDarwNum", DbType.Int32)]
        public int MinDarwNum { get; set; }

        [JsonProperty(PropertyName = "mincommall")]
        [Column("MinCommAll", DbType.Decimal)]
        public decimal MinCommAll { get; set; }

    }
}