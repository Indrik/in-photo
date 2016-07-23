using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using Photographer.Contract.Interfaces;
using Photographer.Contract.Models;

namespace Photographer.Dao
{
    public class PhotoGalleryDao : IPhotoGalleryDao
    {
        public List<GalleryItem> GetGalleryFileNames(string galleryName)
        {
            var galleryDirectory = GetGalleryDirectory(galleryName);
            var fileList = new List<string>();

            if (Directory.Exists(galleryDirectory))
            {
                fileList = Directory.GetFiles(galleryDirectory, "*.jpg").Select(Path.GetFileName).ToList();
            }

            List<GalleryItem> gallery = fileList.Select(x => new GalleryItem
            {
                FileName = x
            }).ToList();

            return gallery;
        }

        private static string GetGalleryDirectory(string galleryName)
        {
            string imageFolder = ConfigurationManager.AppSettings["GalleryPath"];
            string galleryDirectory = $"{imageFolder}{galleryName}";

            string galleryFullPath = HttpContext.Current.Server.MapPath(galleryDirectory);
            return galleryFullPath;
        }
    }
}