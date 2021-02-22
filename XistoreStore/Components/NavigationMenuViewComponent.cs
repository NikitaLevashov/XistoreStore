using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XistoreStore.Models;

namespace XistoreStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IProductRepository _repository;
        public NavigationMenuViewComponent(IProductRepository repo)
        {
            _repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(_repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }

    }

}
