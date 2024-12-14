﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalKitchen.Domain.Package
{
    public interface IPackageFactory
    {
        Package Create(Guid id, string status, string batchCode, Guid preparedRecipeId);
    }

}
