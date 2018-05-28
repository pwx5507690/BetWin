using BW.Enitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BW.Respository
{
    public class SystemCashConfigRespository : BaseRespository<SystemCashConfig>
    {
        public SystemCashConfigRespository(SystemCashConfig sqlDataEnity) : base(sqlDataEnity)
        {
        }

        public override string GetDefaultOrderBy()
        {
            return "order by ID desc";
        }

        public override void SetItemView(SystemCashConfig item, OptionType type)
        {

        }
    }
}