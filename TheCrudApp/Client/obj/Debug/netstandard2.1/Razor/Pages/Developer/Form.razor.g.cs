#pragma checksum "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Form.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eab8b0a02324f199271736a9113c05d5ef78797e"
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
    public partial class Form : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 1 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Form.razor"
                  dev

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Form.razor"
                                       OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<label>First Name :</label>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 6 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Form.razor"
                                     dev.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dev.FirstName = __value, dev.FirstName))));
                __builder2.AddAttribute(16, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dev.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n            ");
                global::__Blazor.TheCrudApp.Client.Pages.Developer.Form.TypeInference.CreateValidationMessage_0(__builder2, 18, 19, 
#nullable restore
#line 7 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Form.razor"
                                      () => dev.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group ");
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.AddMarkupContent(28, "<label>Last Name :</label>\r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 14 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Form.razor"
                                         dev.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dev.LastName = __value, dev.LastName))));
                __builder2.AddAttribute(34, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dev.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                ");
                global::__Blazor.TheCrudApp.Client.Pages.Developer.Form.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 15 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Form.razor"
                                          () => dev.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group ");
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.AddMarkupContent(47, "<label>Email :</label>\r\n            ");
                __builder2.OpenElement(48, "div");
                __builder2.AddMarkupContent(49, "\r\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 23 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Form.razor"
                                         dev.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dev.Email = __value, dev.Email))));
                __builder2.AddAttribute(53, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dev.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n                ");
                global::__Blazor.TheCrudApp.Client.Pages.Developer.Form.TypeInference.CreateValidationMessage_2(__builder2, 55, 56, 
#nullable restore
#line 24 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Form.razor"
                                          () => dev.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group ");
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.AddMarkupContent(66, "<label>Experience :</label>\r\n            ");
                __builder2.OpenElement(67, "div");
                __builder2.AddMarkupContent(68, "\r\n                ");
                global::__Blazor.TheCrudApp.Client.Pages.Developer.Form.TypeInference.CreateInputNumber_3(__builder2, 69, 70, 
#nullable restore
#line 32 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Form.razor"
                                           dev.Experience

#line default
#line hidden
#nullable disable
                , 71, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dev.Experience = __value, dev.Experience)), 72, () => dev.Experience);
                __builder2.AddMarkupContent(73, "\r\n                ");
                global::__Blazor.TheCrudApp.Client.Pages.Developer.Form.TypeInference.CreateValidationMessage_4(__builder2, 74, 75, 
#nullable restore
#line 33 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Form.razor"
                                          () => dev.Experience

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(76, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n\r\n    ");
                __builder2.OpenElement(80, "button");
                __builder2.AddAttribute(81, "type", "submit");
                __builder2.AddAttribute(82, "class", "btn btn-success");
                __builder2.AddMarkupContent(83, "\r\n        ");
#nullable restore
#line 39 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Form.razor"
__builder2.AddContent(84, ButtonText);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(85, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\TE\Downloads\Sanjay\TheCrudApp\TheCrudApp\Client\Pages\Developer\Form.razor"
       
    [Parameter] public Developer dev { get; set; }
    [Parameter] public string ButtonText { get; set; } = "Save";
    [Parameter] public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.TheCrudApp.Client.Pages.Developer.Form
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
