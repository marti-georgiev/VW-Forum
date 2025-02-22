using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using VWForum.Web.Models.Utilities.Binding;

namespace VWForum.Web.Models.Community
{
    public class CreateCommunityModel
    {
        
        public string Name { get; set; }

        
        public string Description { get; set; }

        [Required]
        public string Category { get; set; }

        [BindProperty(BinderType = typeof(TagsModelBinder))]
        public List<string> Tags { get; set; }
    }
}
