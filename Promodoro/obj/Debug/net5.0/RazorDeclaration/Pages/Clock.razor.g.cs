// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Promodoro.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\projects\c#\Promodoro\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projects\c#\Promodoro\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\projects\c#\Promodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\projects\c#\Promodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\projects\c#\Promodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\projects\c#\Promodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\projects\c#\Promodoro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\projects\c#\Promodoro\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\projects\c#\Promodoro\_Imports.razor"
using Promodoro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\projects\c#\Promodoro\_Imports.razor"
using Promodoro.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/clock")]
    public partial class Clock : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "D:\projects\c#\Promodoro\Pages\Clock.razor"
       
    TimeSpan timer = new TimeSpan(0, 25, 0);
    bool isRunning = false;

    private async Task Start()
    {
        isRunning = true;
        while (isRunning)
        {
            await Task.Delay(1000);
            if (isRunning)
            {
                timer = timer.Add(new TimeSpan(0, 0, -1));
                StateHasChanged();
            }

            //tu dong reset khi dem ve 0
            if (timer == new TimeSpan())
            {
                timer = new TimeSpan(0, 25, 0);
                StateHasChanged();
            }
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
