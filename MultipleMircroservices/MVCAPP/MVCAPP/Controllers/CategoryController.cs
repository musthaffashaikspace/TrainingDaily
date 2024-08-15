using Microsoft.AspNetCore.Mvc;
using MVCAPP.Services;

namespace MVCAPP.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService _categoryService;
        public CategoryController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await
           _categoryService.GetCategoriesAsync();
            return View(categories);
        }

    }
}
