using System.Web.Mvc;

namespace Photographer.Controllers
{
    public class PortfolioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}