using Microsoft.AspNetCore.Mvc;

namespace ControllerExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("sayhello")]
        public string methodOne() {
            return "hello from method one";
        }
    
    }
}
