using System.Collections.Generic;

namespace Photographer.Contract
{
    public interface IPhotoGalleryHandler : IWebHandler
    {
        List<string> GetPhotoGallery(string galleryName);
    }
}