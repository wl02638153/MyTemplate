using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyTemplate.Web.Infrastructure;

namespace MyTemplate.Web.Controllers
{
    public class DashboardController : BaseController<HomeController>
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            return View();
        }
    }
}