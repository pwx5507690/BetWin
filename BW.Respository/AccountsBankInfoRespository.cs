using BW.DataSource;
using BW.Enitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW.Respository
{
    public class AccountsBankInfoRespository: BaseRespository<AccountsBankInfo>
    {
        public AccountsBankInfoRespository(AccountsBankInfo accountsBankInfo):base(accountsBankInfo)
        {
            
        }
        public override string GetDefaultOrderBy()
        {
            return "order by ID desc";
        }
    }
}
