using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetNet.DomainModel.Entities;

namespace PetNet.DomainModel.Interfaces.Repositories
{
    public interface IPhotoRepository
    {
        string Create(Photo photo);
        Task<string> CreateAsync(Photo photo);
    }
}
