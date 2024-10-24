using HW3PRO.Models;
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
            var person = new PersonModel
            {
                Name = "Jack Sparrow",
                PhotoUrl = "https://lumiere-a.akamaihd.net/v1/images/bluesteel_d0f846ee.jpeg",
                GroupNumber = "P7",
                ShortInfo = "I'm studyng to be a pirate at 'BLackbeard University'.",
                Hobby = "I like to capture ships and hold seaports.",
                AdditionalInfo = "Particularly talanted and dangerous Pirate."
            };
            return View(person);
        }

        [HttpGet]
        // GET: PersonController/About
        public ActionResult About()
        {
            var person = new PersonModel()
            {
                AdditionalInfo = "Particularly talanted and dangerous Pirate."
            };
            return View(person);
        }

        [HttpGet]
        // GET: PersonController/Hobby
        public ActionResult Hobby()
        {
            var person = new PersonModel()
            {
                Hobby = "I like to capture ships and hold seaports.",
                Name = "Jack Sparrow"
            };
            return View(person);
        }
    }
}
