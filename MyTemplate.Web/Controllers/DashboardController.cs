using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyTemplate.BLL.Service.ControllerService;
using MyTemplate.BLL.Service.EntityRepository;
using MyTemplate.DAL;
using MyTemplate.DAL.Entities;
using MyTemplate.Web.Infrastructure;
using MyTemplate.Web.Models;

namespace MyTemplate.Web.Controllers
{
    public class DashboardController : BaseController<HomeController>
    {
        private IDashboardService _dashboardService;
        public DashboardController(ILogger<DashboardController> logger, MyTemplateDbContext context, IDashboardService dashboardService) : base(logger, context)
        {
            _dashboardService = dashboardService;
        }
        public async Task<IActionResult> Index()
        {
            var test=await _dashboardService.GetAllProduct();
            return View();
        }
        public async Task<IActionResult> Product()
        {
            return View();
        }
        public async Task<IActionResult> ProductList(int page,int size)
        {
            var products = await _dashboardService.GetPaginProduct(page,size);
            var total = await _dashboardService.GetCount();
            
            int pageCount = 0;
            if (total% size==0)
            {
                pageCount = total / size;
            }
            else
            {
                pageCount = (total / size)+1;
            }
            var result = new responseModel<List<Product>>()
            {
                isSuccess = true,
                data = products,
                paginate=new Paginate()
                {
                    Page=page,
                    PageConut= pageCount,
                    Size =size,
                    Total= total
                }
            };
            return Json(result);
        }
    }
}