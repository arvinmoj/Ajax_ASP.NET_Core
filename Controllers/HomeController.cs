using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using My_Application.Models;

namespace My_Application.Controllers
{
    [Route("demo")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("demo1")]
        public IActionResult Demo1()
        {
            return new JsonResult("Hello");
        }

        [Route("demo2/{fullName}")]
        public IActionResult Demo2(string fullName)
        {
            return new JsonResult("Hello " + fullName);
        }

        [Route("demo3")]
        public IActionResult Demo3()
        {
            var product = new Product()
            {
                Id = "p01",
                Name = "name 1",
                Price = 123
            };
            return new JsonResult(product);
        }

        [Route("demo4")]
        public IActionResult Demo4()
        {
            var products = new List<Product>()
            {
                new Product() {
                    Id = "p01",
                    Name = "name 1",
                    Price = 123
                },
                new Product() {
                    Id = "p02",
                    Name = "name 2",
                    Price = 456
                },
                new Product() {
                    Id = "p03",
                    Name = "name 3",
                    Price = 789
                }
            };
            return new JsonResult(products);
        }
    }
}
