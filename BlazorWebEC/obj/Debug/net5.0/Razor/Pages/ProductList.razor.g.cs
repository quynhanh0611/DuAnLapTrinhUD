#pragma checksum "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04f5cd65c93298819b1afb1300d313085295174a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductList")]
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ProductList</h3>");
#nullable restore
#line 4 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\ProductList.razor"
 if (Products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div>Loading</div>");
#nullable restore
#line 7 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\ProductList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div class=\"col pt-4\"><a href=\"/CreateProduct\" class=\"btn btn-success\">Create</a></div>\r\n    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Name</th>\r\n                <th>Price</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 22 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\ProductList.razor"
             foreach (var item in Products)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
#nullable restore
#line 25 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\ProductList.razor"
__builder.AddContent(9, item.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
#nullable restore
#line 26 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\ProductList.razor"
__builder.AddContent(12, item.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\ProductList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\ADMIN\Desktop\Chip\Lập trình ứng dụng web\BlazorWebEC\BlazorWebEC\Pages\ProductList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
