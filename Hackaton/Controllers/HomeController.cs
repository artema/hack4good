using System.Web.Mvc;
using Hackaton.Models;

namespace Hackaton.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            using (var model = new MainModelContainer())
            {
                return View();
            }
        }
    }
}