using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RigidNetRazor_Temp.Data;
using RigidNetRazor_Temp.Models;

namespace RigidNetRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _db;
        public List<Category> CategoryList { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
