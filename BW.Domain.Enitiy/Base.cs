using System;
using BW.DataSource;
using System.Data;
using Newtonsoft.Json;

namespace BW.Enitiy
{
    public class Base<T> : SQLDataEnity<T>
	{
		public Base() : base("Connection")
		{
			
		}
		public Base(string conStr) : base(conStr)
		{
			
		}

		[JsonProperty(PropertyName = "id")]
		[Column("ID", DbType.Int32, ident: true, key: true)]
		public int Id { get; set; }
	}
}
