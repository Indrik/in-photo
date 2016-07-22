using System.Collections.Generic;

namespace Photographer.Contract
{
    public interface IPhotoGalleryHandler
    {
        List<string> GetPhotoGallery(string galleryName);
    }
}