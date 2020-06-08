using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyTemplate.BLL.Service.EntityRepository;
using MyTemplate.DAL;
using MyTemplate.DAL.Entities;
using MyTemplate.Web.Infrastructure;

namespace MyTemplate.Web.Controllers
{
    public class DashboardController : BaseController<HomeController>
    {
        private BaseRepository<Product> BaseContext;
        public DashboardController(ILogger<DashboardController> logger, MyTemplateDbContext context) : base(logger, context)
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product()
        {
            
            return View();
        }
    }
}