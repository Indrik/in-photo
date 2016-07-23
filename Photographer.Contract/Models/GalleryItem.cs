namespace Photographer.Contract.Models
{
    public class GalleryItem
    {
        public string FileName { get; set; }

        public string SmallFileName => FileName;

        public string BigFileName => $"big/{FileName}";
    }
}