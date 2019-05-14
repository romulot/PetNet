using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetNet.DomainModel.Entities;

namespace PetNet.DomainModel.Interfaces.Repositories
{
    public interface IPostRepository
    {
        void Create(Post post);

        void Delete(Guid postId);

        Post Read(Guid postId);

        IEnumerable<Post> ReadAll();

        void Update(Post post);
    }
}
