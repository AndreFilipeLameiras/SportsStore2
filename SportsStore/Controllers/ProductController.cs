using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private ISportsStoreReposity reposity;

        public ProductController(ISportsStoreReposity reposity)
        {
            this.reposity = reposity;
        }
        public IActionResult Index()
        {
            return View(reposity.Products);
        }
    }
}
