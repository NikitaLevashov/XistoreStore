using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XistoreStore.Models;

namespace XistoreStore.Contollers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;
        public int _pageSize = 4; 
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult List(int productPage = 1) => View(_repository.Products
            .OrderBy(p => p.ProductID)
            .Skip((productPage - 1) * _pageSize)
            .Take(_pageSize));
            
    }
}