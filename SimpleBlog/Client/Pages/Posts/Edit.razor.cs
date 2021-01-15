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
    public class EditBase : ComponentBase
    {
        [Inject] public HttpClient Http { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Parameter] public int Id { get; set; }

        public Update.Command Command { get; set; } = new Update.Command();
        public Get.Model Model { get; set; } = new Get.Model();
        
        // Convert HTML to Markdown syntax
        private ReverseMarkdown.Converter converter = new ReverseMarkdown.Converter();
        protected string markdownContent => !string.IsNullOrEmpty(Command.Body) ?  converter.Convert(Command.Body) : "";

        // Preview is HTML
        protected string Preview => !string.IsNullOrEmpty(Command.Body) ? Markdown.ToHtml(Command.Body) : "";

        protected override async Task OnInitializedAsync()
        {
            Model = await Http.GetFromJsonAsync<Get.Model>($"/api/Post/{Id}");
            Command = new Update.Command
            {
                Id = Model.Id,
                Title = Model.Title,
                Body = Model.Body,
            };
        }

        protected async Task HandleFormSubmit()
        {
            if (!string.IsNullOrEmpty(Model.Title) && !string.IsNullOrEmpty(Model.Body))
            {
                Command.Body = Preview;
                await Http.PutAsJsonAsync("/api/Post", Command);
                NavigationManager.NavigateTo($"/post/{Model.Slug}");
            }
        }
    }
}
