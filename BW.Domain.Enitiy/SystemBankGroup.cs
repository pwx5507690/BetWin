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
    public class SystemBankGroup : Base<SystemBankGroup>
    {
        [JsonProperty(PropertyName = "name")]
        [Column("Name", DbType.String)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "code")]
        [Column("Code", DbType.String)]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "state")]
        [Column("State", DbType.Int32)]
        public int State { get; set; }

        [JsonProperty(PropertyName = "add_date")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }

        [JsonProperty(PropertyName = "sort")]
        [Column("Sort", DbType.Int32)]
        public int Sort { get; set; }

    }
}