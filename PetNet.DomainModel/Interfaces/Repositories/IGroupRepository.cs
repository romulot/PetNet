using PetNet.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetNet.DomainModel.Interfaces.Repositories
{
    public interface IGroupRepository
    {
        void Create(Group group);
        Profile Read(Guid group);
        IEnumerable<Group> ReadAll();
        void Update(Group group);
        void Delete(Guid groupId);
    }
}
