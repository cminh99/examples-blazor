#pragma checksum "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\EditMessagesDialog\EditDialogComp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cbf75d293cea74d2936c5848269dc5140ab1d85"
// <auto-generated/>
#pragma warning disable 1591
namespace GroupAllExamples.Components.EditMessagesDialog
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
#nullable restore
#line 1 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\EditMessagesDialog\EditDialogComp.razor"
using GroupAllExamples.Models;

#line default
#line hidden
#nullable disable
    public partial class EditDialogComp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudGrid>(2);
                __builder2.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(4);
                    __builder3.AddAttribute(5, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\EditMessagesDialog\EditDialogComp.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(6, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\EditMessagesDialog\EditDialogComp.razor"
                                 4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.GroupAllExamples.Components.EditMessagesDialog.EditDialogComp.TypeInference.CreateMudTextField_0(__builder4, 8, 9, "Your name", 10, 
#nullable restore
#line 9 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\EditMessagesDialog\EditDialogComp.razor"
                                       Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 11, 
#nullable restore
#line 10 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\EditMessagesDialog\EditDialogComp.razor"
                                        true

#line default
#line hidden
#nullable disable
                        , 12, 
#nullable restore
#line 7 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\EditMessagesDialog\EditDialogComp.razor"
                                           PostedBy

#line default
#line hidden
#nullable disable
                        , 13, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PostedBy = __value, PostedBy)));
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(14, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(15);
                    __builder3.AddAttribute(16, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\EditMessagesDialog\EditDialogComp.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\EditMessagesDialog\EditDialogComp.razor"
                                 8

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.GroupAllExamples.Components.EditMessagesDialog.EditDialogComp.TypeInference.CreateMudTextField_1(__builder4, 19, 20, "Your message", 21, 
#nullable restore
#line 16 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\EditMessagesDialog\EditDialogComp.razor"
                                       Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 22, 
#nullable restore
#line 14 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\EditMessagesDialog\EditDialogComp.razor"
                                           Message

#line default
#line hidden
#nullable disable
                        , 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Message = __value, Message)));
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(24, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(25);
                __builder2.AddAttribute(26, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\EditMessagesDialog\EditDialogComp.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(28, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(30);
                __builder2.AddAttribute(31, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\EditMessagesDialog\EditDialogComp.razor"
                            Update

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(32, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 23 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\EditMessagesDialog\EditDialogComp.razor"
                                           Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(34, "Update");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "D:\Thuc tap\Examples Blazor\GroupAllExamples\GroupAllExamples\Components\EditMessagesDialog\EditDialogComp.razor"
       
    [CascadingParameter]
    private MudDialogInstance MudDialog { get; set; }

    [Parameter]
    public string Message { get; set; }

    [Parameter]
    public string PostedBy { get; set; }

    protected void Update() => MudDialog.Close(DialogResult.Ok(Message));
    protected void Cancel() => MudDialog.Cancel();

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.GroupAllExamples.Components.EditMessagesDialog.EditDialogComp
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Disabled", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591