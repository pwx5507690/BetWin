﻿using BW.Enitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BW.Respository
{
    public class CommInfoRespository : BaseRespository<CommInfo>
    {
        public CommInfoRespository(CommInfo sqlDataEnity) : base(sqlDataEnity)
        {
        }

        public override string GetDefaultOrderBy()
        {
            return "order by ID desc";
        }

        public override void SetItemView(CommInfo item, OptionType type)
        {

        }
    }
}