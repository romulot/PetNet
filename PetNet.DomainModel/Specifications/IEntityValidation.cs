using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetNet.DomainModel.Specifications
{
    public interface IEntityValidation
    {
        bool IsValid();
    }
}
