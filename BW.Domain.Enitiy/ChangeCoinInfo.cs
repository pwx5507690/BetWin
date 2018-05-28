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
    public class ChangeCoinInfo : Base<ChangeCoinInfo>
    {
        [JsonProperty(PropertyName = "changecoin")]
        [Column("ChangeCoin", DbType.Decimal)]
        public decimal ChangeCoin { get; set; }

        [JsonProperty(PropertyName = "usercoin")]
        [Column("UserCoin", DbType.Decimal)]
        public decimal UserCoin { get; set; }

        [JsonProperty(PropertyName = "add_date")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }

        [JsonProperty(PropertyName = "explain")]
        [Column("Explain", DbType.String)]
        public string Explain { get; set; }

        [JsonProperty(PropertyName = "changeorder")]
        [Column("ChangeOrder", DbType.String)]
        public string ChangeOrder { get; set; }

        [JsonProperty(PropertyName = "betcode")]
        [Column("BetCode", DbType.Int32)]
        public int BetCode { get; set; }

        [JsonProperty(PropertyName = "typeid")]
        [Column("TypeID", DbType.Int32)]
        public int TypeID { get; set; }

        [JsonProperty(PropertyName = "typename")]
        [Column("TypeName", DbType.String)]
        public string TypeName { get; set; }

        [JsonProperty(PropertyName = "userid")]
        [Column("UserID", DbType.Int32)]
        public int UserID { get; set; }

        [JsonProperty(PropertyName = "accounts")]
        [Column("Accounts", DbType.String)]
        public string Accounts { get; set; }

    }
}