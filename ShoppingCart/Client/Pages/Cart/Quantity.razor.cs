using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace ShoppingCartStarter.Client.Pages.Cart
{
    public class QuantityBase : ComponentBase
    {
        [Parameter]
        public int Value { get; set; }

        [Parameter]
        public EventCallback<int> ValueChanged { get; set; }

        protected Task OnChange(ChangeEventArgs e)
        {
            Value = Convert.ToInt32(e.Value);
            return ValueChanged.InvokeAsync(Value);
        }
    }
}
