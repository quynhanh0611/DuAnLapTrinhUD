using BlazorWebEC.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModelCommon;

namespace BlazorWebEC.Pages
{
    public partial class ProductList
    {
        [Inject] private IProductApiClient ProductApiClient { get; set; }
        private List<ProductDTO> Products;
        protected override async Task OnInitializedAsync()
        {
            Products = await ProductApiClient.GetProducts();
        }
    }
}
