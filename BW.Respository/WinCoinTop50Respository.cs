using BW.Enitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BW.Respository
{
    public class WinCoinTop50Respository : BaseRespository<WinCoinTop50>
    {
        public WinCoinTop50Respository(WinCoinTop50 sqlDataEnity) : base(sqlDataEnity)
        {
        }

        public override string GetDefaultOrderBy()
        {
            return "order by ID desc";
        }

        public override void SetItemView(WinCoinTop50 item, OptionType type)
        {

        }
    }
}