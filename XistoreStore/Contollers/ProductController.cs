using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XistoreStore.Models;
using XistoreStore.Models.ViewModels;

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
        public ViewResult List(string category, int productPage = 1) => View(new ProductListViewModel
        {
            Products = _repository.Products
            .Where(p=>category==null || p.Category==category)
            .OrderBy(p => p.ProductID)
            .Skip((productPage - 1) * _pageSize)
            .Take(_pageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = _pageSize,
                TotalItems = category == null ? 
                _repository.Products.Count() :
                _repository.Products.Where(e=>
                e.Category==category).Count()
            },
            CurrentCategory=category

        });
    }
}