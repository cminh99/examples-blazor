using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using ShoppingCartStarter.Shared.Cart;

namespace ShoppingCartStarter.Client.Pages.Cart
{
    public class CartBase : ComponentBase
    {
        protected decimal SubTotal = 0m;

        [Inject]
        private HttpClient Http { get; set; }
        
        protected Details.Model Model { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            await ReloadCart();
        }

        protected void RemoveItem(Details.Model.LineItem item)
        {
            Model.Items.Remove(item);
        }

        protected async Task ReloadCart()
        {
            Model = await Http.GetFromJsonAsync<Details.Model>("/api/cart");
            SubTotal = 0m;
            foreach (var item in Model.Items)
            {
                SubTotal += (item.Price * item.Quantity);
            }
        }
    }
}
