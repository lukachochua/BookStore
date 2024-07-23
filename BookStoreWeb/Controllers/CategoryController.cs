using Microsoft.AspNetCore.Mvc;

namespace BookStoreWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}
