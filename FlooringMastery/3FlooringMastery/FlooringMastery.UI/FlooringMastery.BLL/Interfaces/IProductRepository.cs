﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.BLL.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetEveryProduct();
    }
}
