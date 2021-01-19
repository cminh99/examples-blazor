using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ASimpleBlogStarter.Shared.Post;
using Microsoft.AspNetCore.Components;

namespace ASimpleBlogStarter.Client.Pages.Posts
{
    public class ListBase : ComponentBase
    {
        [Inject]
        public IHttpClientFactory HttpClientFactory { get; set; }

        protected ListAll.Model Model { get; set; } = new ListAll.Model();

        protected override async Task OnInitializedAsync()
        {
            var http = HttpClientFactory.CreateClient("ASimpleBlogStarter.AnonymousAPI");
            Model = await http.GetFromJsonAsync<ListAll.Model>("api/post");
        }
    }
}
