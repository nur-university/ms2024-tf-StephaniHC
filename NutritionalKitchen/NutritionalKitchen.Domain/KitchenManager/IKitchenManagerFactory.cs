﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalKitchen.Domain.KitchenManager
{
    public interface IKitchenManagerFactory
    {
        KitchenManager Create(Guid id, string name, string shift);
    }

}
