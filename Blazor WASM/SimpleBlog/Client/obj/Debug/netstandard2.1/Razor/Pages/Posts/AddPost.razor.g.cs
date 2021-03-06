#pragma checksum "D:\blazor fw\thuc tap\SimpleBlog\Client\Pages\Posts\AddPost.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2c4f387114a5c935bf15b29c608efa00d330c56"
// <auto-generated/>
#pragma warning disable 1591
namespace ASimpleBlogStarter.Client.Pages.Posts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\blazor fw\thuc tap\SimpleBlog\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\blazor fw\thuc tap\SimpleBlog\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\blazor fw\thuc tap\SimpleBlog\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\blazor fw\thuc tap\SimpleBlog\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\blazor fw\thuc tap\SimpleBlog\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\blazor fw\thuc tap\SimpleBlog\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\blazor fw\thuc tap\SimpleBlog\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\blazor fw\thuc tap\SimpleBlog\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\blazor fw\thuc tap\SimpleBlog\Client\_Imports.razor"
using ASimpleBlogStarter.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\blazor fw\thuc tap\SimpleBlog\Client\_Imports.razor"
using ASimpleBlogStarter.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\blazor fw\thuc tap\SimpleBlog\Client\Pages\Posts\AddPost.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\blazor fw\thuc tap\SimpleBlog\Client\Pages\Posts\AddPost.razor"
using Markdig;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\blazor fw\thuc tap\SimpleBlog\Client\Pages\Posts\AddPost.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\blazor fw\thuc tap\SimpleBlog\Client\Pages\Posts\AddPost.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/posts/add")]
    public partial class AddPost : AddPostBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .content-wrapper, .preview-wrapper { height: 256px; max-height: 256px; }\r\n    .t_area { resize: none; }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "<h3>Add new post</h3>\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "D:\blazor fw\thuc tap\SimpleBlog\Client\Pages\Posts\AddPost.razor"
                     Command

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "D:\blazor fw\thuc tap\SimpleBlog\Client\Pages\Posts\AddPost.razor"
                                             HandleFormSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label for=\"title\">Title</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "id", "title");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\blazor fw\thuc tap\SimpleBlog\Client\Pages\Posts\AddPost.razor"
                                                                    Command.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Command.Title = __value, Command.Title))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Command.Title));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label for=\"slug\">Slug</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "id", "slug");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\blazor fw\thuc tap\SimpleBlog\Client\Pages\Posts\AddPost.razor"
                                                                   Command.Slug

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Command.Slug = __value, Command.Slug))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Command.Slug));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "row");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-lg-6 mb-sm-3");
                __builder2.AddMarkupContent(34, "<label for=\"body\">Content</label>\r\n                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "content-wrapper");
                __builder2.OpenElement(37, "textarea");
                __builder2.AddAttribute(38, "class", "form-control h-100 t_area");
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "D:\blazor fw\thuc tap\SimpleBlog\Client\Pages\Posts\AddPost.razor"
                                                                             Command.Body

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Command.Body = __value, Command.Body));
                __builder2.SetUpdatesAttributeName("Value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-lg-6");
                __builder2.AddMarkupContent(44, "<label>Preview</label>\r\n                ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "preview-wrapper border rounded px-3 py-1 text-dark");
                __builder2.AddContent(47, 
#nullable restore
#line 37 "D:\blazor fw\thuc tap\SimpleBlog\Client\Pages\Posts\AddPost.razor"
                      (MarkupString)Preview

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "d-flex justify-content-between align-items-center my-3");
                __builder2.OpenElement(51, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(52);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.AddMarkupContent(54, "<button type=\"submit\" class=\"btn btn-primary\">Publish</button>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
