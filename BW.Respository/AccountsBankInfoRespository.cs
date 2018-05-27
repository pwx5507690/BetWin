using BW.Enitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW.Respository
{
    public class AccountsBankInfoRespository
    {
        private readonly AccountsBankInfo _accountsBankInfo;
        public AccountsBankInfoRespository(AccountsBankInfo accountsBankInfo) {
            _accountsBankInfo = accountsBankInfo;    
        }
        public IEnumerable<AccountsBankInfo> Query()
        {
            return _accountsBankInfo.Query();
        }
    }
}
