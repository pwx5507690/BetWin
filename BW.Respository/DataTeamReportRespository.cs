using BW.Enitiy;
using BW.Enitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BW.Respository
{
    public class DataTeamReportRespository : BaseRespository<DataTeamReport>
    {
        public DataTeamReportRespository(DataTeamReport sqlDataEnity) : base(sqlDataEnity)
        {
        }

        public override string GetDefaultOrderBy()
        {
            return "order by ID desc";
        }

        public override void SetItemView(DataTeamReport item, OptionType type)
        {

        }
    }
}