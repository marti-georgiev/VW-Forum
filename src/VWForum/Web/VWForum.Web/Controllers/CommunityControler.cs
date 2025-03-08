using Microsoft.AspNetCore.Mvc;
using VWForum.Service.Community;
using VWForum.Service.Models;
using VWForum.Web.Models.Community;

namespace VWForum.Web.Controllers
{
    public class CommunityController : Controller
    {
        private readonly ICategoryService categoryService;

        public CommunityController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult>Create()
        {
            return View("~/Views/Shared/Create.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> CreateConfirm(CreateCommunityModel createCommunityModel)
        {
           
                await this.categoryService.CreateAsync(new CategoryServiceModel
                {
                    Name = createCommunityModel.Name,
                    Description = createCommunityModel.Description,
                    Tags = createCommunityModel.Tags.Select(tag => new TagsServiceModel { Lable = tag }).ToList()
                });
          
            
            return RedirectToAction("Index", "Home");
        }
    }
}
