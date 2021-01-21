using GroupAllExamples.Data;
using GroupAllExamples.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAllExamples.Services
{
    public class CartServices
    {
        private readonly IDbContextFactory<AppDbContext> _contextFactory;

        public CartServices(IDbContextFactory<AppDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<List<CartItem>> GetItems()
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                return await context.CartItems.ToListAsync();
            }
        }

        public async Task<CartItem> UpdateItemQuantity(int itemId, int itemQuantity)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                CartItem itemToUpdate = await context.CartItems.FindAsync(itemId);

                if (itemToUpdate != null) { itemToUpdate.Quantity = itemQuantity; }

                var updatedItem = context.CartItems.Update(itemToUpdate);
                await context.SaveChangesAsync();
                return updatedItem.Entity;
            }
        }

        public async Task<CartItem> DeleteItem(int itemId)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                CartItem itemToDelete = await context.CartItems.FindAsync(itemId);

                if (itemToDelete != null)
                {
                    var deleteditem = context.CartItems.Remove(itemToDelete);
                    await context.SaveChangesAsync();
                }
                //return (itemToDelete != null) ? context.CartItems.Remove(itemToDelete).Entity : null;
                return itemToDelete;
            }
        }
    }
}
