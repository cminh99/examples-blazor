// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SlackClone.Features
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
#line 2 "D:\learn blazor fw\_test\SlackClone\Features\Slack.razor"
using SlackClone.Features.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\learn blazor fw\_test\SlackClone\Features\Slack.razor"
using SlackClone.Features.PostMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\learn blazor fw\_test\SlackClone\Features\Slack.razor"
using SlackClone.Features.EditMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\learn blazor fw\_test\SlackClone\Features\Slack.razor"
using SlackClone.Domain;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/slack")]
    public partial class Slack : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "D:\learn blazor fw\_test\SlackClone\Features\Slack.razor"
       
    private List<SlackMessage> messages;

    protected override void OnInitialized()
    {
        messages = new List<SlackMessage>
        {
            new SlackMessage
            {
                PostedBy = "Cong Minh",
                PostedOn = DateTime.Now,
                Message = "Hello Quoc Tuan!",
            },
            new SlackMessage
            {
                PostedBy = "Quoc Tuan",
                PostedOn = DateTime.Now,
                Message = "Hello Cong Minh!",
            }
        };
    }

    protected void HandleNewMessage(SlackMessage message)
    {
        messages.Add(message);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
