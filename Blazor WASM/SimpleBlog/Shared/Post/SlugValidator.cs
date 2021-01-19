using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ASimpleBlogStarter.Shared.Post
{
    public interface ISlugValidator
    {
        Task<bool> IsUnique(string slug);
    }
}
