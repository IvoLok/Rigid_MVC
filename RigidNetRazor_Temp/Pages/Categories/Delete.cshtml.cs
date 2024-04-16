using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RigidNetRazor_Temp.Data;
using RigidNetRazor_Temp.Models;

namespace RigidNetRazor_Temp.Pages.Categories
{
	[BindProperties]
	public class DeleteModel : PageModel
	{
		private ApplicationDbContext _db;
		public Category Category { get; set; }
		public DeleteModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet(int? Id)
		{
			if (!(Id == null && Id == 0))
			Category = _db.Categories.Find(Id);

			NotFound();
		}
		public IActionResult OnPost()
		{
			_db.Categories.Remove(Category);
			_db.SaveChanges();
			TempData["success"] = "Category Deleted successfully";
			return RedirectToPage("Index");
		}
	}
}
