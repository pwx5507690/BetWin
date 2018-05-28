using BW.Enitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW.Respository
{
    public class SystemBankTypeRespository : BaseRespository<SystemBankType>
    {
        public SystemBankTypeRespository(SystemBankType sqlDataEnity) : base(sqlDataEnity)
        {
        }

        public override string GetDefaultOrderBy()
        {
            return "order by ID desc";
        }

        public override void SetItemView(SystemBankType item, OptionType type)
        {
            return;
        }
    }
}
