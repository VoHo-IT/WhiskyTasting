using System.Web.Mvc;

namespace WhiskyTasting.Controllers
{
    public class WhiskyController : Controller
    {
        // GET: Whisky
        public ActionResult Index()
        {
            return View();
        }
    }
}