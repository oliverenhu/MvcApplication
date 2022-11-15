using System.Web.Mvc;
using MvcApplication.Models;
namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}