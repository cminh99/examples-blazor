#pragma checksum "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\Cart\QuantityComp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c3ff856220795323ecab63c48402e91f797e0b0"
// <auto-generated/>
#pragma warning disable 1591
namespace GroupAllExamples.Components.Cart
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
    public partial class QuantityComp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "select");
            __builder.AddAttribute(1, "class", "form-control form-control-sm");
            __builder.AddAttribute(2, "value", 
#nullable restore
#line 1 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\Cart\QuantityComp.razor"
                                                     Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "disabled", 
#nullable restore
#line 1 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\Cart\QuantityComp.razor"
                                                                       Disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 1 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\Cart\QuantityComp.razor"
                                                                                            OnChange

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(5, "option");
            __builder.AddAttribute(6, "value", "1");
            __builder.AddContent(7, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "option");
            __builder.AddAttribute(10, "value", "2");
            __builder.AddContent(11, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", "3");
            __builder.AddContent(15, "3");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", "4");
            __builder.AddContent(19, "4");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", "5");
            __builder.AddContent(23, "5");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\Cart\QuantityComp.razor"
       
    [Parameter]
    public int Value { get; set; }
    
    [Parameter]
    public bool Disabled { get; set; }

    [Parameter]
    public EventCallback<int> ValueChanged { get; set; }

    protected Task OnChange(ChangeEventArgs e)
    {
        Value = Convert.ToInt32(e.Value);
        return ValueChanged.InvokeAsync(Value);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
