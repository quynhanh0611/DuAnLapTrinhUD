using BlazorWebEC.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebEC.API.IRepositories
{
    //Lớp interface trừu tượng đưa ra các method chung cho model
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductList();

        Task<Product> Create(Product product);

        Task<Product> Update(Product product);

        Task<Product> Delete(Product product);

        Task<Product> GetById(int id);
    }
}
