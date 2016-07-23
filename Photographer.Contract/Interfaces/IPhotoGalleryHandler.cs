using System.Collections.Generic;
using Photographer.Contract.Models;

namespace Photographer.Contract.Interfaces
{
    public interface IPhotoGalleryHandler : IWebHandler
    {
        List<GalleryItem> GetPhotoGallery(string galleryName);
    }
}