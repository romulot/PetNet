using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetNet.DomainModel.Entities
{
    public class ProfileGroup : EntityBase
    {
        public Profile Profile { get; set; }
        public Group Group { get; set; }
    }
}
