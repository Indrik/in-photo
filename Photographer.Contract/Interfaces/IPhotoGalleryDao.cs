using System.Collections.Generic;
using Photographer.Contract.Models;

namespace Photographer.Contract.Interfaces
{
    public interface IPhotoGalleryDao : IService
    {
        List<GalleryItem> GetGalleryFileNames(string galleryName);
    }
}