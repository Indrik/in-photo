using System.Collections.Generic;

namespace Photographer.Contract
{
    public interface IPhotoGalleryService
    {
        List<string> GetGalleryFileNames(string galleryName);
    }
}