#pragma checksum "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\CreateProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6b444ffb11e44315b8169568b6c5c50023032df"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebEC.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\_Imports.razor"
using BlazorWebEC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\_Imports.razor"
using BlazorWebEC.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\CreateProduct.razor"
using BlazorWebEC.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\CreateProduct.razor"
using ViewModelCommon;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CreateProduct")]
    public partial class CreateProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreateProduct</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\CreateProduct.razor"
                 Product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\CreateProduct.razor"
                                         SubmitTask

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-group");
                __builder2.AddMarkupContent(7, "<label for=\"Name\">Id</label>\r\n        ");
                __Blazor.BlazorWebEC.Pages.CreateProduct.TypeInference.CreateInputNumber_0(__builder2, 8, 9, "form-control", 10, 
#nullable restore
#line 10 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\CreateProduct.razor"
                                                       Product.Id

#line default
#line hidden
#nullable disable
                , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Id = __value, Product.Id)), 12, () => Product.Id);
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.AddMarkupContent(14, "<small id=\"nameHelp\" class=\"form-text text-muted\">Please enter product id here.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "<label for=\"Name\">Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\CreateProduct.razor"
                                                     Product.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Name = __value, Product.Name))));
                __builder2.AddAttribute(23, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.AddMarkupContent(25, "<small id=\"nameHelp\" class=\"form-text text-muted\">Please enter product name here.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "<label for=\"Name\">Price</label>\r\n        ");
                __Blazor.BlazorWebEC.Pages.CreateProduct.TypeInference.CreateInputNumber_1(__builder2, 30, 31, "form-control", 32, 
#nullable restore
#line 20 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\CreateProduct.razor"
                                                       Product.Price

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Price = __value, Product.Price)), 34, () => Product.Price);
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.AddMarkupContent(36, "<small id=\"nameHelp\" class=\"form-text text-muted\">Please enter product price here.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.AddMarkupContent(38, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\CreateProduct.razor"
       
    private ProductRequest Product = new ProductRequest();

    private async Task SubmitTask(EditContext context)
    {
        var result = await ProductApiClient.CreateProduct(Product);
        if (result)
        {
            NavigationManager.NavigateTo("/ProductList");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductApiClient ProductApiClient { get; set; }
    }
}
namespace __Blazor.BlazorWebEC.Pages.CreateProduct
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591