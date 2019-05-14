using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetNet.DataAccess.Contexts;
using PetNet.DomainModel.Entities;
using PetNet.DomainModel.Interfaces.Repositories;

namespace PetNet.DataAccess.Repositories
{
    public class PhotoAlbumEntityFrameworkRepository : IPhotoAlbumRepository
    {
        private SocialNetworkContext _socialNetworkContext;

        public PhotoAlbumEntityFrameworkRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
        }

        public void Create(PhotoAlbum photoAlbum)
        {
            _socialNetworkContext.PhotoAlbums.Add(photoAlbum);
        }

        public void Delete(Guid photoAlbumId)
        {
            throw new NotImplementedException();
        }

        public PhotoAlbum Read(Guid photoAlbumId)
        {
            return _socialNetworkContext.PhotoAlbums.Find(photoAlbumId);
        }

        public IEnumerable<PhotoAlbum> ReadAll()
        {
            return _socialNetworkContext.PhotoAlbums;
        }

        public void Update(PhotoAlbum photoAlbum)
        {
            _socialNetworkContext.Entry(photoAlbum).State = EntityState.Modified;
            _socialNetworkContext.SaveChanges();
        }
    }
}
