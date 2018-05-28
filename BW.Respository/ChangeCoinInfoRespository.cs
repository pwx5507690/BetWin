using BW.Enitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BW.Respository
{
    public class ChangeCoinInfoRespository : BaseRespository<ChangeCoinInfo>
    {
        public ChangeCoinInfoRespository(ChangeCoinInfo sqlDataEnity) : base(sqlDataEnity)
        {
        }

        public override string GetDefaultOrderBy()
        {
            return "order by ID desc";
        }

        public override void SetItemView(ChangeCoinInfo item, OptionType type)
        {

        }
    }
}