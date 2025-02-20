using Microsoft.AspNetCore.Mvc;

namespace VWForum.Web.Controllers
{
    public class CommunityControler : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
