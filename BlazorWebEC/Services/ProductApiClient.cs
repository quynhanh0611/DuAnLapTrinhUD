using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ViewModelCommon;

namespace BlazorWebEC.Services
{
    //Lớp kế thừa từ interface IProductApiClient để triển khai và gọi đến api
    public class ProductApiClient : IProductApiClient
    {
        public HttpClient _httpClient;//Http client để dùng các pt call đến các cổng của API để nhận dữ liệu
        public ProductApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateProduct(ProductRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/product", request);// đây là pt call api để tạo mới sản phẩm 
            return result.IsSuccessStatusCode;
        }

        public Task<bool> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductDTO>> GetProducts()
        {
            var result = await _httpClient.GetFromJsonAsync<List<ProductDTO>>("api/product");// đây là pt call api lấy ra ds sản phẩm
            return result;
        }

        public Task<ProductDTO> GetTaskDetail(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProduct(int id, ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
