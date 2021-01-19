using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ASimpleBlogStarter.Shared.Post;

namespace ASimpleBlogStarter.Client.Shared
{
    public class SlugValidator : ISlugValidator
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public SlugValidator(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<bool> IsUnique(string slug)
        {
            var http = _httpClientFactory.CreateClient("ASimpleBlogStarter.AnonymousAPI");
            var res = await http.GetAsync($"api/post/search?slug={slug}");
            return res.StatusCode == System.Net.HttpStatusCode.NotFound;
        }
    }
}
