using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Homework.Controllers
{
    public class AllTypesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nothing()
        {
            return new EmptyResult();
        }


        public ContentResult ContentResult(string name)
        {
            string currentDateTime = string.Format("Hello {0}.\nCurrent DateTime: {1}", name, DateTime.Now.ToString());
            return Content(currentDateTime);
        }
        public FileContentResult FileContentActionResult()
        {
            var file = System.IO.File.ReadAllBytes(@"C:\Users\User\Documents\Visual Studio 2017\Projects\VS2017Test\VS2017Test\Controllers\HomeController.cs");

            return File(file, "text/plain", "HomeController.cs");
        }
        public FileResult GetFile()
        {
            return File(@"c:\Users\User\Desktop\Untitled.png", "application/png");
        }
        //public IActionResult JavaScriptResult()
        //{
        //    return JavaScript("alert('Hello world!');");
        //}

        public IActionResult JsonData()
        {
            object homework = new { HomeworkID = 1, AuthorName = "Goran Kuzmanoski" };
            return new JsonResult(homework);
        }
        public JsonResult JsonActionResult()
        {
            var data = new { Name = "Goran", LastName = "Kuzmanoski" };

            return Json(data);
        }

        public IActionResult BackToHome()
        {
            return RedirectToAction("Index");
        }

        public PartialViewResult PartialViewActionResult()
        {
            var model = new List<int> { 2, 3 };

            return PartialView("_PartialViewActionResult", model);
        }

    }
}