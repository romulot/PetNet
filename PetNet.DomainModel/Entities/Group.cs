using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetNet.DomainModel.Entities
{
    public class Group : EntityBase
    {
        public string Name { get; set; }
        public Profile Owner { get; set; }
        public string Subject { get; set; }
    }

}
