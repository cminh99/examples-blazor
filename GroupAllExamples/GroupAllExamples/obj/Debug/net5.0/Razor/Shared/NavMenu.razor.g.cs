#pragma checksum "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9dc875a07c230f526684a4de72265f4d8ae1260"
// <auto-generated/>
#pragma warning disable 1591
namespace GroupAllExamples.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\_Imports.razor"
using GroupAllExamples;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\_Imports.razor"
using GroupAllExamples.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\_Imports.razor"
using MudBlazor.Dialog;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-5yg4z8q2r5");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href Match=\"NavLinkMatch.All\" b-5yg4z8q2r5>\r\n        GroupAllExamples\r\n    </a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-5yg4z8q2r5");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-5yg4z8q2r5></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 10 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-5yg4z8q2r5");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-5yg4z8q2r5");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-5yg4z8q2r5");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "counter");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-5yg4z8q2r5></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "nav-item px-3");
            __builder.AddAttribute(28, "b-5yg4z8q2r5");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "nav-link");
            __builder.AddAttribute(31, "href", "fetchdata");
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(33, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-5yg4z8q2r5></span> Fetch data\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "nav-item px-3");
            __builder.AddAttribute(37, "b-5yg4z8q2r5");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
            __builder.AddAttribute(39, "class", "nav-link");
            __builder.AddAttribute(40, "href", "/pomodoro");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(42, "<span class=\"oi oi-clock\" aria-hidden=\"true\" b-5yg4z8q2r5></span> Pomodoro Clock\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "li");
            __builder.AddAttribute(45, "class", "nav-item px-3");
            __builder.AddAttribute(46, "b-5yg4z8q2r5");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
            __builder.AddAttribute(48, "class", "nav-link");
            __builder.AddAttribute(49, "href", "slack");
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(51, "<span class=\"oi oi-book\" aria-hidden=\"true\" b-5yg4z8q2r5></span> Slack Clone\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "li");
            __builder.AddAttribute(54, "class", "nav-item px-3");
            __builder.AddAttribute(55, "b-5yg4z8q2r5");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(56);
            __builder.AddAttribute(57, "class", "nav-link");
            __builder.AddAttribute(58, "href", "cart");
            __builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(60, "<span class=\"oi oi-cart\" aria-hidden=\"true\" b-5yg4z8q2r5></span> Shopping Cart\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.OpenElement(62, "li");
            __builder.AddAttribute(63, "class", "nav-item px-3");
            __builder.AddAttribute(64, "b-5yg4z8q2r5");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(65);
            __builder.AddAttribute(66, "class", "nav-link");
            __builder.AddAttribute(67, "href", "posts");
            __builder.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(69, "<span class=\"oi oi-tags\" aria-hidden=\"true\" b-5yg4z8q2r5></span> Blog Posts\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
