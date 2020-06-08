using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyTemplate.BLL.Service.EntityRepository;
using MyTemplate.DAL;
using MyTemplate.DAL.Entities;
using MyTemplate.Web.Infrastructure;
using MyTemplate.Web.Models;

namespace MyTemplate.Web.Controllers
{
    //[Authorize]
    public class HomeController : BaseController<HomeController>
    {
        private readonly IBaseRepository<Product> _productRep;
        public HomeController(ILogger<HomeController> logger, MyTemplateDbContext context, IBaseRepository<Product> productRep) : base(logger, context)
        {
            _productRep = productRep;
        }

        public IActionResult Index()
        {
            var test=_context.Set<Product>();
            var test2 = _productRep.GetAll();
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
