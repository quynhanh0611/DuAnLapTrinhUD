using BlazorWebEC.API.Data;
using BlazorWebEC.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebEC.API.IRepositories
{
    //kế thừa từ interface IProductRepository triển khai các logic để thực thi .
    public class ProductRepository : IProductRepository
    {
        //Nhập 1 bản sao BlazorWebDbContext vào lớp này để thao tác với database
        private readonly BlazorWebDbContext _context;
        public ProductRepository(BlazorWebDbContext context)
        {
            _context = context;
        }
        public async Task<Product> Create(Product product)
        {
            await _context.Products.AddAsync(product);//  Thao tác thêm mới
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> Delete(Product product)
        {
            _context.Products.Remove(product);// Thao tác xóa
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> GetById(int id)
        {
            return await _context.Products.FindAsync(id);// Thao tác lấy sản phẩm có id là gì
        }

        public async Task<IEnumerable<Product>> GetProductList()
        {
            return await _context.Products.ToListAsync();// Lấy tất cả các sản phẩm đã có
        }

        public async Task<Product> Update(Product product)
        {
            _context.Products.Update(product);//Thao tác sửa sản phẩm đã có trong database.
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
