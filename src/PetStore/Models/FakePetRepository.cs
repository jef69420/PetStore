using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models
{
    public class FakePetRepository : IPetRepository
    {
        public IEnumerable<Pet> Customer => new List<Pet>
        {
            new Pet { PetID = 001, Name = "Johnny", Description = "Asdfghjkl", Type = "Dog", Image = "Dog.jpg"},
        };
    }
}
