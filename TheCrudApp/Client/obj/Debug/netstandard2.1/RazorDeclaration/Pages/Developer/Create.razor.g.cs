// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TheCrudApp.Client.Pages.Developer
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\91908\Desktop\BlazorCrud\TheCrudApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\91908\Desktop\BlazorCrud\TheCrudApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\91908\Desktop\BlazorCrud\TheCrudApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\91908\Desktop\BlazorCrud\TheCrudApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\91908\Desktop\BlazorCrud\TheCrudApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\91908\Desktop\BlazorCrud\TheCrudApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\91908\Desktop\BlazorCrud\TheCrudApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\91908\Desktop\BlazorCrud\TheCrudApp\Client\_Imports.razor"
using TheCrudApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\91908\Desktop\BlazorCrud\TheCrudApp\Client\_Imports.razor"
using TheCrudApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\91908\Desktop\BlazorCrud\TheCrudApp\Client\_Imports.razor"
using TheCrudApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/developer/create")]
    public partial class Create : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\91908\Desktop\BlazorCrud\TheCrudApp\Client\Pages\Developer\Create.razor"
       
    Developer dev = new Developer();
    async Task CreateDeveloper()
    {
        await http.PostAsJsonAsync("api/developer", dev);
        await js.InvokeVoidAsync("swal", "Success!", "Developer created successfully.", "success");
        uriHelper.NavigateTo("developer");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
