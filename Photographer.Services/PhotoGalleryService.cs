using System.Collections.Generic;
using Photographer.Contract;

namespace Photographer.Services
{
    public class PhotoGalleryService : IPhotoGalleryService
    {
        private readonly IPhotoGalleryDao _photoGalleryDao;

        public PhotoGalleryService(IPhotoGalleryDao photoGalleryDao)
        {
            _photoGalleryDao = photoGalleryDao;
        }

        public List<string> GetGalleryFileNames(string galleryName)
        {
            return _photoGalleryDao.GetGalleryFileNames(galleryName);
        }
    }
}