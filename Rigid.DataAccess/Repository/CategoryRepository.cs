using Rigid.DataAccess.Data;
using Rigid.DataAccess.Repository.IRepository;
using Rigid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rigid.DataAccess.Repository
{
	public class CategoryRepository : Repository<Category>, ICategoryRepository
	{
		private ApplicationDbContext _db;
		public CategoryRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

		public void Save()
		{
			_db.SaveChanges();
		}

		public void Update(Category obj)
		{
			_db.Categories.Update(obj);
		}
	}
}
