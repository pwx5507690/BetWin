using BW.Enitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BW.Respository
{
    public class SystemPayInfoRespository : BaseRespository<SystemPayInfo>
    {
        public SystemPayInfoRespository(SystemPayInfo sqlDataEnity) : base(sqlDataEnity)
        {
        }

        public override string GetDefaultOrderBy()
        {
            return "order by ID desc";
        }

        public override void SetItemView(SystemPayInfo item, OptionType type)
        {

        }
    }
}