#pragma checksum "D:\Thuc tap\Source code [Git-Github]\Blazor Server\BlazorServer\Pages\Slack\Messages\Time.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ff174e09fcd1e9901431d6f570ea8f9b0ce0382"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Pages.Slack.Messages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Thuc tap\Source code [Git-Github]\Blazor Server\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Thuc tap\Source code [Git-Github]\Blazor Server\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Thuc tap\Source code [Git-Github]\Blazor Server\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Thuc tap\Source code [Git-Github]\Blazor Server\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Thuc tap\Source code [Git-Github]\Blazor Server\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Thuc tap\Source code [Git-Github]\Blazor Server\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Thuc tap\Source code [Git-Github]\Blazor Server\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Thuc tap\Source code [Git-Github]\Blazor Server\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Thuc tap\Source code [Git-Github]\Blazor Server\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Thuc tap\Source code [Git-Github]\Blazor Server\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
    public partial class Time : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "span");
            __builder.AddContent(1, 
#nullable restore
#line 1 "D:\Thuc tap\Source code [Git-Github]\Blazor Server\BlazorServer\Pages\Slack\Messages\Time.razor"
       Value.ToString("hh:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "D:\Thuc tap\Source code [Git-Github]\Blazor Server\BlazorServer\Pages\Slack\Messages\Time.razor"
       
    [Parameter]
    public DateTime Value { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
