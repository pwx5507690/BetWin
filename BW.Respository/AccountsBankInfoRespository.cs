using BW.DataSource;
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
        private readonly string _defaultOrderBy;
        public AccountsBankInfoRespository(AccountsBankInfo accountsBankInfo)
        {
            _accountsBankInfo = accountsBankInfo;
            _defaultOrderBy = "order by ID desc";
        }
        public int Add(AccountsBankInfo item)
        {
            return _accountsBankInfo.Add(item);
        }
        public int Update(AccountsBankInfo item)
        {
            return _accountsBankInfo.Update(item);
        }
        public void Delete(AccountsBankInfo item)
        {
            _accountsBankInfo.Delete(item);
        }
        public SQLPage<AccountsBankInfo> Query(int pageSize, int currentPage, string expression = null)
        {
            if (string.IsNullOrEmpty(expression))
                return _accountsBankInfo.Query(pageSize, currentPage);

            var condition = new SQLCondition();
            condition.Expression = $"where {expression} {_defaultOrderBy}";
            return _accountsBankInfo.Query(pageSize, currentPage, condition);
        }
    }
}
