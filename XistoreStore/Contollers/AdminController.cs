using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XistoreStore.Models;

namespace XistoreStore.Contollers
{
    public class AdminController : Controller
    {
        private IProductRepository _repository;
        public AdminController(IProductRepository repo)
        {
            _repository = repo;
        }
        public ViewResult Index() => View(_repository.Products);
       
    }
}