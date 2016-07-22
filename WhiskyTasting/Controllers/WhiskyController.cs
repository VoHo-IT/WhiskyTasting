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
        public ActionResult Suchen(string userName, string herkunft)
        {
            ViewBag.userName = userName;
            ViewBag.referer = herkunft;

            return View();
        }
    }
}