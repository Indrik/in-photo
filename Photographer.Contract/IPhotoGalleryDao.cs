using System.Collections.Generic;

namespace Photographer.Contract
{
    public interface IPhotoGalleryDao : IService
    {
        List<string> GetGalleryFileNames(string galleryName);
    }
}