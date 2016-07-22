using System.Collections.Generic;
using Photographer.Contract;

namespace Photographer.Handlers
{
    public class PhotoGalleryHandler : IPhotoGalleryHandler
    {
        public List<string> GetPhotoGallery(string galleryName)
        {
            return new List<string>();
        }
    }
}