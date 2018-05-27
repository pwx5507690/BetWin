using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BW.App.Result
{
    public class TableResult: JsonNetResult
    {
        public class Table
        {
            public object Rows { get; set; }
            public int Results { get; set; }
        }
        public TableResult(Table table)
        {
            this.Data = table;
        }
    }
}