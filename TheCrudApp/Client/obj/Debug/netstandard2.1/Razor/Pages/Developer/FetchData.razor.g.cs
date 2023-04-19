#pragma checksum "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "499844feed43a977d1cbd597ab829f75050c2803"
// <auto-generated/>
#pragma warning disable 1591
namespace TheCrudApp.Client.Pages.Developer
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\_Imports.razor"
using TheCrudApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\_Imports.razor"
using TheCrudApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\_Imports.razor"
using TheCrudApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/developer")]
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Developers Team</h3>\r\n \r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\">\r\n    <a class=\"btn btn-success\" href=\"developer/create\"><i class=\"oi oi-outline-plus\"></i> Create New</a>\r\n</div>\r\n<br>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\FetchData.razor"
 if (developers == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "Loading...");
#nullable restore
#line 14 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\FetchData.razor"
                           
}
else if (developers.Length == 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "No Records Found.");
#nullable restore
#line 18 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\FetchData.razor"
                                  
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-striped");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.AddMarkupContent(8, @"<thead>
                <tr>
                    <th>Id</th>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Email</th>
                    <th>Experience (Years)</th>
                    <th></th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 34 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\FetchData.razor"
             foreach (Developer dev in developers)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                        ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                            ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 37 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\FetchData.razor"
__builder.AddContent(15, dev.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                            ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 38 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\FetchData.razor"
__builder.AddContent(18, dev.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                            ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 39 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\FetchData.razor"
__builder.AddContent(21, dev.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 40 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\FetchData.razor"
__builder.AddContent(24, dev.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "td");
#nullable restore
#line 41 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\FetchData.razor"
__builder.AddContent(27, dev.Experience);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "td");
            __builder.AddMarkupContent(30, "\r\n                                ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "class", "btn btn-success");
            __builder.AddAttribute(33, "href", "developer/edit/" + (
#nullable restore
#line 43 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\FetchData.razor"
                                                                                 dev.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-danger");
            __builder.AddAttribute(38, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\FetchData.razor"
                                                                           () => Delete(dev.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 47 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 50 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\FetchData.razor"
       
    Developer[] developers { get; set; }
    protected override async Task OnInitializedAsync()
    {
        developers = await client.GetFromJsonAsync<Developer[]>("api/developer");
    }

    async Task Delete(int developerId)
    {
        var dev = developers.First(x => x.Id == developerId);
        if (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {dev.FirstName}'s ({dev.Id}) Record?"))
        {
            await client.DeleteAsync($"api/developer/{developerId}");
            await OnInitializedAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
