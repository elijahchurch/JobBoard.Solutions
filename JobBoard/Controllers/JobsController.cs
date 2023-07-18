using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
    public class JobsController : Controller
    {
        [HttpGet("/jobs/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [HttpGet("/jobs")]
        public ActionResult Index()
        {
            List<JobOpening> allJobs = JobOpening.GetAll();
            return View(allJobs);
        }

        [HttpPost("/jobs")]
        public ActionResult Create(string name, string description, string email)
        {
            JobOpening newJob = new JobOpening(name, description, email);
            return RedirectToAction("Index");
        }
    }
}