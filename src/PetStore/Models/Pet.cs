using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models
{
    public class Pet
    {
        public int PetID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
    }
}
