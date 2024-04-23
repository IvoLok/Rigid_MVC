using Rigid.DataAccess.Data;
using Rigid.DataAccess.Repository.IRepository;
using Rigid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rigid.DataAccess.Repository
{
	internal class ProductRepository : Repository<Product>, IProductRepository
	{
		private ApplicationDbContext _db;
		public ProductRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

		public void Update(Product obj)
		{
			_db.Products.Update(obj);
		}
	}
}
