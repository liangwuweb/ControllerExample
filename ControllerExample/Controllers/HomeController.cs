using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace ControllerExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("home")]
        public ContentResult Index() {
            return Content("<h3>Hello from Index<h3>", "text / html");
        }

        [Route("about")]
        public string About()
        {
            return "hello from About";
        }

        [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
        public string Contact()
        {
            return "hello from Contact";
        }
    }
}
