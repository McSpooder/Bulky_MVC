﻿using Microsoft.AspNetCore.Mvc;
using ProductSolution.DataAccess.Repository.IRepository;
using ProductSolution.Utility;
using System.Security.Claims;

namespace ProductSolution.web.ViewComponents
{
    public class OrderViewComponent : ViewComponent {

        private readonly IUnitOfWork _unitOfWork;
        public OrderViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            if (claim != null)
            {
                if (HttpContext.Session.GetInt32(SD.SessionCart) != null)
                {
                    HttpContext.Session.SetInt32(SD.SessionCart,
                   _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == claim.Value).Count());
                }
               
                return View(HttpContext.Session.GetInt32(SD.SessionCart));
            }
            else
            {
                HttpContext.Session.Clear();
                return View("$0.00");
            }
        }

    }
}