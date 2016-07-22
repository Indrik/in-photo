using System.Web.Mvc;
using Photographer.Contract;

namespace Photographer.Controllers
{
    public class HomeController : Controller
    {
        public IPhotoGalleryHandler PhotoGalleryHandler { get; set; }

        public ActionResult Index()
        {
            return View();
        }
    }
}