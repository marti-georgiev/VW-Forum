using Microsoft.AspNetCore.Mvc;
using VWForum.Data.Models;
using VWForum.Web.Models.Thread;


namespace VWForum.Web.Controllers
{
    public class ThreadController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult CreateConfirm(ThreadCreateModel creatThreadModel)
        {
            return View();
        }

    }
}
