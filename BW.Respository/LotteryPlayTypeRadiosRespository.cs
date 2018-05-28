using BW.Enitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BW.Respository
{
    public class LotteryPlayTypeRadiosRespository : BaseRespository<LotteryPlayTypeRadios>
    {
        public LotteryPlayTypeRadiosRespository(LotteryPlayTypeRadios sqlDataEnity) : base(sqlDataEnity)
        {
        }

        public override string GetDefaultOrderBy()
        {
            return "order by ID desc";
        }

        public override void SetItemView(LotteryPlayTypeRadios item, OptionType type)
        {

        }
    }
}