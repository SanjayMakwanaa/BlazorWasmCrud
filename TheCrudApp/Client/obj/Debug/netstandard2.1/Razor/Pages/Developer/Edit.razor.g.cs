#pragma checksum "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12bc65bc212b43c85be2c64cf33a86c7ac2eabd3"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/developer/edit/{developerId:int}")]
    public partial class Edit : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit</h3>\r\n\r\n");
            __builder.OpenComponent<global::TheCrudApp.Client.Pages.Developer.Form>(1);
            __builder.AddAttribute(2, "ButtonText", "Update");
            __builder.AddAttribute(3, "dev", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::TheCrudApp.Shared.Models.Developer>(
#nullable restore
#line 8 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Edit.razor"
                               dev

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Edit.razor"
                      EditDeveloper

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Edit.razor"
       
    [Parameter] public int developerId { get; set; }
    Developer dev = new Developer();

    protected async override Task OnParametersSetAsync()
    {
        dev = await http.GetFromJsonAsync<Developer>($"api/developer/{developerId}");
    }

    async Task EditDeveloper()
    {
        await http.PutAsJsonAsync("api/developer", dev);
        await js.InvokeVoidAsync("alert", $"Updated Successfully!");
        uriHelper.NavigateTo("developer");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
