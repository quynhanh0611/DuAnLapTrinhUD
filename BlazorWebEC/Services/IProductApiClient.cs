using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ViewModelCommon;

namespace BlazorWebEC.Services
{
    //dịch vụ để giao tiếp với api
    public interface IProductApiClient
    {
        Task<List<ProductDTO>> GetProducts();//lấy ra ds sản phẩm
        Task<ProductDTO> GetTaskDetail(string id);// lấy ra chi tiết sản phẩm
        Task<bool> CreateProduct(ProductRequest request);//tạo sản phẩm mới
        Task<bool> UpdateProduct(int id, ProductUpdateRequest request);//update sản phẩm cũ
        Task<bool> DeleteProduct(int id);// xóa sản phẩm 
    }
}
