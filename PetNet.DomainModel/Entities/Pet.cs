using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetNet.DomainModel.Entities
{
    public class Pet
    {
        public string Name { get; set; }
        public Profile Owner { get; set; }

        public PetType PetType { get; set; }
   
        public string Breed { get; set; }
        public string PhotoUrl { get; set; }
    }

    public enum PetType { dog, cat, turtle, bunny, hamster, fish, bird}
}
