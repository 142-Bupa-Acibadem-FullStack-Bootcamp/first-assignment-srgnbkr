﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccessLayer.Abstract
{
    public interface IOrderRepesitory
    {
        IQueryable OrderReport();
    }
}