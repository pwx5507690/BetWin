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
    public class AccountsInfo : SQLDataEnity<AccountsInfo>
    {
        public AccountsInfo() : base("Connection")
        {

        }
 //       [UserID] [int] IDENTITY(1,1) NOT NULL,
	//[Accounts] [nvarchar](31) NOT NULL,
	//[NickName] [nvarchar](31) NOT NULL,
	//[Compellation] [nvarchar](16) NULL,
	//[LogonPass] [nvarchar](32) NOT NULL,
	//[InsurePass] [nvarchar](32) NULL,
	//[Nullity] [tinyint] NOT NULL,
	//[NullityOverDate] [datetime] NULL,
	//[LogonTimes] [int] NULL,
	//[LastLogonIP] [nvarchar](15) NULL,
	//[LastLogonDate] [datetime] NULL,
	//[RegisterIP] [nvarchar](15) NOT NULL,
	//[RegisterDate] [datetime] NOT NULL,
	//[UserType] [tinyint] NOT NULL,
	//[ParentID] [int] NOT NULL,
	//[Rebate] [int] NOT NULL,
	//[UserRight] [nvarchar](255) NOT NULL,
	//[UserLayer] [int] NOT NULL,
	//[IsDemo] [tinyint] NOT NULL,
	//[Coin] [decimal](18, 4) NULL,
	//[CodeCoin] [decimal](18, 4) NULL,
	//[CompCodeCoin] [decimal](18, 4) NULL,
	//[Score] [decimal](18, 4) NULL,
	//[ScoreTotal] [decimal](18, 4) NULL,
	//[SignCount] [int] NULL,
	//[OLType] [tinyint] NULL,
	//[OLState] [tinyint] NULL,
	//[BankFlag] [tinyint] NULL,
	//[ParentStr] [nvarchar](255) NULL,
	//[RegFrom] [tinyint] NULL,
        [JsonProperty(PropertyName = "id")]
        [Column("ID", DbType.Int32, ident: true, key: true)]
        public int Id { get; set; }
    }
}
