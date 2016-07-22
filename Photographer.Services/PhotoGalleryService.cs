using System.Collections.Generic;
using Photographer.Contract;

namespace Photographer.Services
{
    public class PhotoGalleryService : IPhotoGalleryService
    {
        public List<string> GetGalleryFileNames(string galleryName)
        {
            return new List<string>();
        }
    }
}
