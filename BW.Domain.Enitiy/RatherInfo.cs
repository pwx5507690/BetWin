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
    public class RatherInfo : Base<RatherInfo>
    {
        [JsonProperty(PropertyName = "lotterycode")]
        [Column("LotteryCode", DbType.String)]
        public string LotteryCode { get; set; }

        [JsonProperty(PropertyName = "openresult")]
        [Column("OpenResult", DbType.String)]
        public string OpenResult { get; set; }

        [JsonProperty(PropertyName = "issuecode")]
        [Column("IssueCode", DbType.String)]
        public string IssueCode { get; set; }

        [JsonProperty(PropertyName = "opendate")]
        [Column("OpenDate", DbType.DateTime)]
        public DateTime OpenDate { get; set; }

        [JsonProperty(PropertyName = "add_date")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }

        [JsonProperty(PropertyName = "explain")]
        [Column("Explain", DbType.String)]
        public string Explain { get; set; }

    }
}