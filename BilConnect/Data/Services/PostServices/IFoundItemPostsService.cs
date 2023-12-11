﻿using BilConnect.Data.Base;
using BilConnect.Data.ViewModels.PostViewModels;
using BilConnect.Models.PostModels;

namespace BilConnect.Data.Services.PostServices
{
    public interface IFoundItemPostsService : IEntityBaseRepository<FoundItemPost>
    {
        Task AddNewPostAsync(NewFoundItemPostVM data);
        Task UpdatePostAsync(NewFoundItemPostVM data);
    }
}