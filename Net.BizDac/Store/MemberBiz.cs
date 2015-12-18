﻿using Net.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.BizDac.Store
{
    public class MemberBiz
    {
        public List<MemberT> getAllMembers()
        {
            return new MemberDac().SelectAllMembers();
        }
    }
}
