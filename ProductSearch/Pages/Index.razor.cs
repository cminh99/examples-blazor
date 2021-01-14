using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ProductSearch.Data;

namespace ProductSearch.Pages
{
    public class IndexBase : ComponentBase
    {
        protected string SearchTerm { get; set; }

        protected List<Product> Products { get; set; } = new List<Product>
        {
            new Data.Product
            {
                Title = "Smart Speaker",
                Price = 22m,
                Image = "https://via.placeholder.com/48",
            },
            new Data.Product
            {
                Title = "T-Shirt",
                Price = 9m,
                Image = "https://via.placeholder.com/48",
            },
            new Data.Product
            {
                Title = "Nike Airmax 270",
                Price = 39m,
                Image = "https://via.placeholder.com/48",
            },
            new Data.Product
            {
                Title = "Adidas Ultraboot 5.0",
                Price = 37m,
                Image = "https://via.placeholder.com/48",
            }
        };

        protected IEnumerable<Product> SearchResults =>
            Products.Where(p => string.IsNullOrEmpty(SearchTerm) || p.Title.ToLower().Contains(SearchTerm.ToLower()));
    }
}
