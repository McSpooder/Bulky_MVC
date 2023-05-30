using ProductSolution.DataAccess.Data;
using ProductSolution.DataAccess.Repository;
using ProductSolution.DataAccess.Repository.IRepository;
using ProductSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductSolution.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(Product obj)
        {
            _db.Products.Update(obj);
        }

    }
}
