using BW.Enitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BW.Respository
{
    public class BetsOrderInfoRespository : BaseRespository<BetsOrderInfo>
    {
        public BetsOrderInfoRespository(BetsOrderInfo sqlDataEnity) : base(sqlDataEnity)
        {
        }

        public override string GetDefaultOrderBy()
        {
            return "order by ID desc";
        }

        public override void SetItemView(BetsOrderInfo item, OptionType type)
        {

        }
    }
}