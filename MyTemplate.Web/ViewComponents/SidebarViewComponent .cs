using Microsoft.AspNetCore.Mvc;
using MyTemplate.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTemplate.Web.ViewComponents
{
    public class SidebarViewComponent : BaseViewComponent<SidebarViewComponent>
    {
        public SidebarViewComponent() { }
        public async Task<IViewComponentResult> InvokeAsync() => View("Sidebar");
    }
}
