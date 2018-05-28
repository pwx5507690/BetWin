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
    public class AccountsFeedBack : Base<AccountsFeedBack>
    {
        [JsonProperty(PropertyName = "userID")]
        [Column("UserID", DbType.Int32)]
        public int UserID { get; set; }
        //      
        [JsonProperty(PropertyName = "title")]
        [Column("Title", DbType.String)]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "Info")]
        [Column("Info", DbType.String)]
        public string Info { get; set; }

        [JsonProperty(PropertyName = "addDate")]
        [Column("Add_Date", DbType.String)]
        public string Add_Date { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Int32)]
        public int State { get; set; }

        [JsonProperty(PropertyName = "backInfo")]
        [Column("BackInfo", DbType.String)]
        public string BackInfo { get; set; }

        [JsonProperty(PropertyName = "backDate")]
        [Column("Back_Date", DbType.String)]
        public string Back_Date { get; set; }
    }
}
