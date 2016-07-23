using System.Collections.Generic;
using Photographer.Contract.Interfaces;
using Photographer.Contract.Models;

namespace Photographer.Handlers
{
    public class PhotoGalleryHandler : IPhotoGalleryHandler
    {
        private readonly IPhotoGalleryService _photoGalleryService;

        public PhotoGalleryHandler(IPhotoGalleryService photoGalleryService)
        {
            _photoGalleryService = photoGalleryService;
        }

        public List<GalleryItem> GetPhotoGallery(string galleryName)
        {
            return _photoGalleryService.GetGalleryFileNames(galleryName);
        }
    }
}