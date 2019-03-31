﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scrumban.DataAccessLayer.Interfaces
{
    interface IUnitOfWork
    {
        void Save();
        void Dispose();
    }
}
