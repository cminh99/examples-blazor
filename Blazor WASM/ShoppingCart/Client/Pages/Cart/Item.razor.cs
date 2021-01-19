using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using ShoppingCartStarter.Shared.Cart;
using ShoppingCartStarter.Shared.Cart.LineItem;
using Microsoft.AspNetCore.Components;

namespace ShoppingCartStarter.Client.Pages.Cart
{
    public class ItemBase : ComponentBase
    {
        [Parameter]
        public Details.Model.LineItem Details { get; set; }

        [Parameter]
        public EventCallback<Details.Model.LineItem> OnDeleted { get; set; }

        [Parameter]
        public EventCallback OnQuantityChanged { get; set; }

        [Inject]
        private HttpClient Http { get; set; }

        protected async Task HandleDelete()
        {
            await Http.DeleteAsync($"api/cart/lines/{Details.Id}");
            await OnDeleted.InvokeAsync(Details);
        }

        protected async Task QuantityChanged(int value)
        {
            await Http.PutAsJsonAsync("/api/cart/lines", new Update.Command
            {
                Id = Details.Id,
                Quantity = value
            });
            await OnQuantityChanged.InvokeAsync(EventArgs.Empty);
        }
    }
}
