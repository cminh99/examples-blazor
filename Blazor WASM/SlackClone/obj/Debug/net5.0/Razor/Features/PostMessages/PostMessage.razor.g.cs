#pragma checksum "D:\learn blazor fw\_test\SlackClone\Features\PostMessages\PostMessage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdbc50cdd13c112372c99eae94029835c062d17f"
// <auto-generated/>
#pragma warning disable 1591
namespace SlackClone.Features.PostMessages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using SlackClone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\learn blazor fw\_test\SlackClone\_Imports.razor"
using SlackClone.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\learn blazor fw\_test\SlackClone\Features\PostMessages\PostMessage.razor"
using SlackClone.Domain;

#line default
#line hidden
#nullable disable
    public partial class PostMessage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card mt-3");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "D:\learn blazor fw\_test\SlackClone\Features\PostMessages\PostMessage.razor"
                         NewMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "D:\learn blazor fw\_test\SlackClone\Features\PostMessages\PostMessage.razor"
                                                    HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "placeholder", "Type your message!");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "D:\learn blazor fw\_test\SlackClone\Features\PostMessages\PostMessage.razor"
                                                                                                  NewMessage.Message

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewMessage.Message = __value, NewMessage.Message))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NewMessage.Message));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "div");
                __builder2.AddMarkupContent(18, "<button class=\"btn btn-primary\" type=\"submit\">Post</button>\r\n                ");
                __builder2.OpenElement(19, "span");
                __builder2.AddContent(20, 
#nullable restore
#line 11 "D:\learn blazor fw\_test\SlackClone\Features\PostMessages\PostMessage.razor"
                       warning

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "D:\learn blazor fw\_test\SlackClone\Features\PostMessages\PostMessage.razor"
       
    // NewMessage
    // {
    //    PostedBy;
    //    PostedOn;
    //    Message;
    // }
    public SlackMessage NewMessage { get; set; } = new SlackMessage();
    public string warning = "";

    // EventCallback is used to communicate between children and parent
    [Parameter]
    public EventCallback<SlackMessage> OnPosted { get; set; }

    protected async Task HandleSubmit()
    {
        if (!string.IsNullOrEmpty(NewMessage.Message))
        {
            NewMessage.PostedBy = "Minh Man";
            NewMessage.PostedOn = DateTime.Now;
            await OnPosted.InvokeAsync(NewMessage);

            NewMessage = new SlackMessage();
            warning = "";
        }
        else
        {
            warning = "Please enter a message!";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591