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
   public class AccountsIds: Base<AccountsIds>
    {
        [JsonProperty(PropertyName = "userID")]
        [Column("UserID", DbType.Int32)]
        public int UserId { get; set; }

        [JsonProperty(PropertyName = "parentID")]
        [Column("ParentID", DbType.Int32)]
        public int ParentID { get; set; }

        [JsonProperty(PropertyName = "allPatentStr")]
        [Column("AllPatentStr", DbType.String)]
        public string AllPatentStr { get; set; }

        [JsonProperty(PropertyName = "allNextStr")]
        [Column("AllNextStr", DbType.String)]
        public string AllNextStr { get; set; }
    }
}
