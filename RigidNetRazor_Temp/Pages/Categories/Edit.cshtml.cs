using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RigidNetRazor_Temp.Data;
using RigidNetRazor_Temp.Models;

namespace RigidNetRazor_Temp.Pages.Categories
{
	[BindProperties]
	public class EditModel : PageModel
	{
		private ApplicationDbContext _db;
		public Category Category { get; set; }
		public EditModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet(int? Id)
		{
			if (!(Id == null && Id == 0))
			{
				Category = _db.Categories.Find(Id);
			}
		}
		public IActionResult OnPost()
		{
			if (ModelState.IsValid)
			{
				_db.Categories.Update(Category);
				_db.SaveChanges();
				TempData["success"] = "Category updated successfully";
				return RedirectToPage("Index");
			}
			return Page();
		}

	}
}
