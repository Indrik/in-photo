using System.Collections.Generic;
using Photographer.Contract.Models;

namespace Photographer.Contract.Interfaces
{
    public interface IPhotoGalleryService : IService
    {
        List<GalleryItem> GetGalleryFileNames(string galleryName);
    }
}