﻿using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstraction.Repository
{
    public interface IProductRepository
    {
        void Insert(Proizvod proizvod);
    }
}
