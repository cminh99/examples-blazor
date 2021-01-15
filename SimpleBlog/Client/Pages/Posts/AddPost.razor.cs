using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ASimpleBlogStarter.Shared.Post;
using Markdig;
using Microsoft.AspNetCore.Components;

namespace ASimpleBlogStarter.Client.Pages.Posts
{
    public class AddPostBase : ComponentBase
    {
        [Inject] public HttpClient Http { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        protected Add.Command Command { get; set; } = new Add.Command();

        // Cách 1: Get text of Body and Parse it in AddPost.razor
        protected string Preview => Command.Body != null ? Markdown.ToHtml(Command.Body) : "";
        // Cách 2: Get text of Body and Parse it here, then binding it in AddPost.razor
        //protected string Preview => Command.Body != null ? Markdown.ToHtml(Command.Body) : "";

        protected async Task HandleFormSubmit()
        {
            if (!string.IsNullOrEmpty(Command.Title) && !string.IsNullOrEmpty(Command.Body))
            {
                Command.Body = Preview;
                await Http.PostAsJsonAsync("api/post", Command);
                NavigationManager.NavigateTo($"/post/{Command.Slug}");
            }
        }
    }
}
