#pragma checksum "D:\learn blazor (thuc tap)\@test\Promodoro\Pages\Timer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a0d7e31c55702774ec9685d08bcea43086fa924"
// <auto-generated/>
#pragma warning disable 1591
namespace Promodoro.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\learn blazor (thuc tap)\@test\Promodoro\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\learn blazor (thuc tap)\@test\Promodoro\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\learn blazor (thuc tap)\@test\Promodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\learn blazor (thuc tap)\@test\Promodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\learn blazor (thuc tap)\@test\Promodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\learn blazor (thuc tap)\@test\Promodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\learn blazor (thuc tap)\@test\Promodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\learn blazor (thuc tap)\@test\Promodoro\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\learn blazor (thuc tap)\@test\Promodoro\_Imports.razor"
using Promodoro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\learn blazor (thuc tap)\@test\Promodoro\_Imports.razor"
using Promodoro.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pomodoro")]
    public partial class Timer : TimerBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "style", "color:" + " " + (
#nullable restore
#line 4 "D:\learn blazor (thuc tap)\@test\Promodoro\Pages\Timer.razor"
                   changeColor()

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(2, 
#nullable restore
#line 5 "D:\learn blazor (thuc tap)\@test\Promodoro\Pages\Timer.razor"
     remaining

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\learn blazor (thuc tap)\@test\Promodoro\Pages\Timer.razor"
                  Start

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "disabled", 
#nullable restore
#line 8 "D:\learn blazor (thuc tap)\@test\Promodoro\Pages\Timer.razor"
                                    isStart

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, "Start");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\learn blazor (thuc tap)\@test\Promodoro\Pages\Timer.razor"
                  Stop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "disabled", 
#nullable restore
#line 9 "D:\learn blazor (thuc tap)\@test\Promodoro\Pages\Timer.razor"
                                   isStop

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, "Stop");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\learn blazor (thuc tap)\@test\Promodoro\Pages\Timer.razor"
                  Reset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "disabled", 
#nullable restore
#line 10 "D:\learn blazor (thuc tap)\@test\Promodoro\Pages\Timer.razor"
                                    isReset

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, "Reset");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
