using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XistoreStore.Infrastructure;
using XistoreStore.Models;
using XistoreStore.Models.ViewModels;

namespace XistoreStore.Contollers
{
    public class CartController : Controller
    {
        private IProductRepository repository;

        private Cart cart;
        public CartController(IProductRepository repo, Cart cartService)
        {
            cart = cartService;
            repository = repo;
        }
               
        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });

        }
        public RedirectToActionResult AddToCart(int productId, string returnUrl)
        {
             Product product = repository.Products
                     .FirstOrDefault(p => p.ProductID == productId);
                       
            if (product != null)
            {
                cart.AddItem(product, 1);
            }

            return RedirectToAction("Index", new { returnUrl });

        }
               
        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productId);
                       
            if (product != null)
            {
                cart.RemoveLine(product);
            }

            return RedirectToAction("Index", new { returnUrl });

        }
      
    }
}