using VWForum.Data.Models;

namespace VWForum.Service
{
    internal interface ICategoryRepository
    {
        void CreateAsync(Category category);
    }
}