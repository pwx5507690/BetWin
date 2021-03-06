﻿using BW.DataSource;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BW.Enitiy
{
    public class WinCoinTop50 : Base<WinCoinTop50>
    {
        [JsonProperty(PropertyName = "accounts")]
        [Column("Accounts", DbType.String)]
        public string Accounts { get; set; }

        [JsonProperty(PropertyName = "issuecode")]
        [Column("IssueCode", DbType.String)]
        public string IssueCode { get; set; }

        [JsonProperty(PropertyName = "wincoin")]
        [Column("WinCoin", DbType.String)]
        public string WinCoin { get; set; }

        [JsonProperty(PropertyName = "lotterycode")]
        [Column("LotteryCode", DbType.String)]
        public string LotteryCode { get; set; }

        [JsonProperty(PropertyName = "add_date")]
        [Column("Add_Date", DbType.DateTime)]
        public DateTime Add_Date { get; set; }
    }
}