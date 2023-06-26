using ProductSolution.DataAccess.Data;
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
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
