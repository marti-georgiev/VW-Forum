using Microsoft.AspNetCore.Mvc.Core;
namespace VWForum.Service.Models
{
    public class TagsModelBider : IModelBider
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var result = bindingContext.ValueProvider.GetValue("Tags").Values[0]?.Split(",").ToList();

            bindingContext.Result = ModelBindingResult.Success(result);
            return Task.CompletedTask;
        }
    }
}
