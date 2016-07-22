using System.Collections.Generic;
using Photographer.Contract;

namespace Photographer.Handlers
{
    public class PhotoGalleryHandler : IPhotoGalleryHandler
    {
        private readonly IPhotoGalleryService _photoGalleryService;

        public PhotoGalleryHandler(IPhotoGalleryService photoGalleryService)
        {
            _photoGalleryService = photoGalleryService;
        }

        public List<string> GetPhotoGallery(string galleryName)
        {
            return _photoGalleryService.GetGalleryFileNames(galleryName);
        }
    }
}