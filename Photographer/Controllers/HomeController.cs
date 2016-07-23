using System.Collections.Generic;
using System.Web.Mvc;
using Photographer.Contract.Interfaces;
using Photographer.Contract.Models;

namespace Photographer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPhotoGalleryHandler _photoGalleryHandler;

        public HomeController(IPhotoGalleryHandler photoGalleryHandler)
        {
            _photoGalleryHandler = photoGalleryHandler;
        }

        public ActionResult Index()
        {
            List<GalleryItem> galleryList = _photoGalleryHandler.GetPhotoGallery("home");

            return View(galleryList);
        }
    }
}