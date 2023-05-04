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

        [Route("file-download")]
        public VirtualFileResult FileDownload()
        {
            //return new VirtualFileResult("/sample.pdf", "application/pdf");
            return File("/sample.pdf", "application/pdf");
        }

        [Route("file-download-physical")]
        public PhysicalFileResult FileDownload2()
        {
            //return new PhysicalFileResult("C:\\Users\\liang\\source\\aspnetcore\\sample2.pdf", "application/pdf");
            return PhysicalFile("C:\\Users\\liang\\source\\aspnetcore\\sample2.pdf", "application/pdf");
        }

        [Route("file-download-byte")]
        public FileContentResult FileDownload3()

        {
            byte[] bytes = System.IO.File.ReadAllBytes("C:\\Users\\liang\\source\\aspnetcore\\sample2.pdf");
            //return new FileContentResult(bytes, "application/pdf");
            return File(bytes, "application/pdf");
        }

        [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
        public string Contact()
        {
            return "hello from Contact";
        }
    }
}
