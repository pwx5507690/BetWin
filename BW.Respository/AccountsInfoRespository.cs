using BW.Enitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW.Respository
{
    public class AccountsInfoRespository : BaseRespository<AccountsInfo>
    {
        public AccountsInfoRespository(AccountsInfo sqlDataEnity) : base(sqlDataEnity)
        {
        }

        public override string GetDefaultOrderBy()
        {
            return "order by UserID desc";
        }

        public override void SetItemView(AccountsInfo item, OptionType type)
        {
            if (type == OptionType.Add)
                item.RegisterDate = DateTime.UtcNow;
            
        }
    }
}
