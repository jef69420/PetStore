﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models
{
    public interface IPetRepository
    {
        IEnumerable<Pet> Customer { get; }
    }
}
