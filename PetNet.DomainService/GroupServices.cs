using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetNet.DomainModel.Entities;
using PetNet.DomainModel.Interfaces.Repositories;

namespace PetNet.DomainService
{
    public class GroupServices
    {
        private IGroupRepository _groupRepository;

        public GroupServices(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        // Criar Grupo
       public void CreateGroup(Group group)
        {
            _groupRepository.Create(group);
        }

        // Atualizar Grupo
        public void UpdateGroup(Group group)
        {
            _groupRepository.Update(group);
        }
       
        // Deletar Grupo
        public void DeleteGroup(Guid groupId)
        {
            _groupRepository.Delete(groupId);
        }

        // Get Grupo
        public void GetGroup(Guid groupId)
        {
            _groupRepository.Read(groupId);
        }

        // Buscar Grupo por Nome
        public IEnumerable<Group> SearchGroupByName(string name)
        {
            return _groupRepository.ReadAll()
                .Where(p => p.Name.ToLower().Contains(name.ToLower()));
        }

    }
}
