using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyTemplate.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTemplate.Web.Infrastructure
{
    //[Authorize]
    public class BaseController<T> : Controller
    {
        protected readonly ILogger<BaseController<T>> _logger;
        protected readonly MyTemplateDbContext _context;
        protected BaseController(ILogger<BaseController<T>> logger, MyTemplateDbContext context)
        {
            _logger = logger;
            _context = context;
        }
    }
}
