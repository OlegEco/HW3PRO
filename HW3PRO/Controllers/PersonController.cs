using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HW3PRO.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        // Get: PersonController/Index
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        // GET: PersonController/About
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        // GET: PersonController/Hobby
        public ActionResult Hobby()
        {
            return View();
        }
    }
}
