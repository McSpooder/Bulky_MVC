﻿using ProductSolution.DataAccess.Data;
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
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
