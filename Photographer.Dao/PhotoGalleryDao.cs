using System.Collections.Generic;
using Photographer.Contract;

namespace Photographer.Dao
{
    public class PhotoGalleryDao : IPhotoGalleryDao
    {
        public List<string> GetGalleryFileNames(string galleryName)
        {
            return new List<string>();
        }
    }
}