﻿using BW.Enitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BW.Respository
{
    public class SystemPayTypeRespository : BaseRespository<SystemPayType>
    {
        public SystemPayTypeRespository(SystemPayType sqlDataEnity) : base(sqlDataEnity)
        {
        }

        public override string GetDefaultOrderBy()
        {
            return "order by ID desc";
        }

        public override void SetItemView(SystemPayType item, OptionType type)
        {

        }
    }
}