using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using ControllerExample.Models;

namespace ControllerExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("home")]
        public ContentResult Index() {
            return Content("<h3>Hello from Index<h3>", "text / html");
        }

        [Route("person")]
        public JsonResult Person()
        {
            Person person = new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = "Test",
                LastName = "Test",
                Age = 28
            }; 
            //return new JsonResult(person);
            return Json(person);
        }

        [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
        public string Contact()
        {
            return "hello from Contact";
        }
    }
}
