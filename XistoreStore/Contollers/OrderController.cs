﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XistoreStore.Models;

namespace XistoreStore.Contollers
{
    public class OrderController : Controller
    {
        private IOrderRepository _repository;
        private Cart _cart;
        public OrderController(IOrderRepository repoService,Cart cartService)
        {
            _repository = repoService;
            _cart = cartService;
        }
        public ViewResult Checkout() => View(new Order());
       
        [HttpPost]
        public IActionResult Checkout (Order order)
        {
            if(_cart.Lines.Count()==0)
            {
                ModelState.AddModelError("", "Извините,ваша корзина пуста!");
            }
            if (ModelState.IsValid)
            {
                order.Lines = _cart.Lines.ToArray();
                _repository.SaveOrder(order);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(order);
            }
        }
        public ViewResult Completed()
        {
            _cart.Clear();
            return View();
        }
    }

}