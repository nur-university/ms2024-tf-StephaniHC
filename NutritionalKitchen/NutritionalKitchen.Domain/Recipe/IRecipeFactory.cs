﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalKitchen.Domain.Recipe
{
    public interface IRecipeFactory
    {
        Recipe Create(Guid id, string name, string preparationTime);
    }
}
