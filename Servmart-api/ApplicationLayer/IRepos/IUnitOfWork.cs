﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.IRepos
{
    public interface IUnitOfWork
    {
        int CommitChanges();
    }
}
