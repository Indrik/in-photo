using System.Collections.Generic;

namespace Photographer.Contract
{
    public interface IPhotoGalleryService : IService
    {
        List<string> GetGalleryFileNames(string galleryName);
    }
}