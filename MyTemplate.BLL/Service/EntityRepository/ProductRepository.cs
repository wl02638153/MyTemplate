using MyTemplate.DAL;
using MyTemplate.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTemplate.BLL.Service.EntityRepository
{
    public class ProductRepository: IBaseRepository<Product>
    {
        private readonly MyTemplateDbContext _context;
        public ProductRepository(MyTemplateDbContext context)
        {
            _context = context;
        }

        public Task<Product> Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            //return _context.FindAsync<Product>();
            throw new NotImplementedException();
        }

        public Task<Product> GetById(string id)
        {
            //return _context.Products.SingleOrDefault(x => x.Id.ToString()==id);
            throw new NotImplementedException();
        }

        public Task Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
