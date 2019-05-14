using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetNet.DomainModel.Entities;

namespace PetNet.DomainModel.Interfaces.Repositories
{
    public interface IProfileRepository
    {
        void Create(Profile profile);
        Profile Read(Guid post);
        IEnumerable<Profile> ReadAll();
        void Update(Profile profile);
        void Delete(Guid post);
    }
}
