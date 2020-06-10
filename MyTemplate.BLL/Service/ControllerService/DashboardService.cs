using MyTemplate.BLL.Service.EntityRepository;
using MyTemplate.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyTemplate.BLL.Service.ControllerService
{
    public interface IDashboardService
    {
        Task<List<Product>> GetAllProduct();
        Task<List<Product>> GetPaginProduct(int page, int size);
        Task<int> GetCount();
    }
    public class DashboardService:IDashboardService
    {
        private IRepository<Product> _productRep;
        public DashboardService(IRepository<Product> productRep)
        {
            _productRep = productRep;
        }
        /// <summary>
        /// 取得產品列表
        /// </summary>
        /// <param name=""></param>
        /// <returns>產品列表</returns>
        public async Task<List<Product>> GetAllProduct()
        {
            return await _productRep.GetAll();
        }
        public async Task<List<Product>> GetPaginProduct(int page,int size)
        {
            return await _productRep.GetPagin(page, size);
        }
        public async Task<int> GetCount()
        {
            return await _productRep.GetCount();
        }
    }
}
