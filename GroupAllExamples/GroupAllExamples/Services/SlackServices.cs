using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupAllExamples.Data;
using GroupAllExamples.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupAllExamples.Services
{
    public class SlackServices
    {
        private readonly IDbContextFactory<AppDbContext> _contextFactory;

        public SlackServices(IDbContextFactory<AppDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<List<SlackMessage>> GetMessages()
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                return await context.SlackMessages.ToListAsync();
            }
        }

        public async Task<SlackMessage> AddMessage(SlackMessage newMessage)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                newMessage.PostedOn = DateTime.Now;
                var addedMessage = await context.SlackMessages.AddAsync(newMessage);
                await context.SaveChangesAsync();
                return addedMessage.Entity;
            }
        }

        public async Task<SlackMessage> UpdateMessage(int messageId, SlackMessage newMessage)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                SlackMessage messageToUpdate = await context.SlackMessages.FindAsync(messageId);
                
                if (messageToUpdate != null)
                {
                    messageToUpdate.PostedOn = DateTime.Now;
                    messageToUpdate.Message = newMessage.Message;
                    messageToUpdate.Like = newMessage.Like;
                }

                var updatedMessage = context.SlackMessages.Update(messageToUpdate);
                await context.SaveChangesAsync();
                return updatedMessage.Entity;
            }
        }
    }
}
