using Microsoft.AspNetCore.Mvc;

namespace JobBoard.Controllers
{
    public class JobsController : Controller
    {
        [HttpGet("/jobs/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
    }
}