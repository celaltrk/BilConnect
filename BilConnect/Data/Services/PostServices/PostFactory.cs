﻿using BilConnect.Data.Enums;
using BilConnect.Data.ViewModels.PostViewModels;
using BilConnect.Models.PostModels;

namespace BilConnect.Data.Services.PostServices
{
    public class PostFactory : IPostFactory
    {
        public Post CreatePost(NewPostVM viewModel)
        {
            void InitializeSharedProperties(Post post, NewPostVM vm)
            {
                post.Title = vm.Title;
                post.Description = vm.Description;
                post.ImageURL = vm.ImageURL;
                post.PostDate = DateTime.UtcNow;
                post.PostStatus = vm.PostStatus;
                post.UserId = vm.UserId;
            }

            Post newPost = null;

            if (viewModel.PostType == PostType.SellingPost)
            {
                newPost = new SellingPost
                {
                    Price = viewModel.PriceS ?? 0
                };
            }
            else if (viewModel.PostType == PostType.DonationPost)
            {
                newPost = new DonationPost();
            }
            else if (viewModel.PostType == PostType.BorrowingPost)
            {
                var borrowingPost = new BorrowingPost
                {
                    Price = viewModel.PriceB ?? 0,
                    ReturnDate = viewModel.ReturnDate
                };

                newPost = borrowingPost;
            }
            else if (viewModel.PostType == PostType.EventTicketPost)
            {
                var eventTicketPost = new EventTicketPost
                {   
                    EventTime = viewModel.EventTime,
                    EventPlace = viewModel.EventPlace,
                    Price = viewModel.PriceE ?? 0
                };

                

                newPost = eventTicketPost;
            }
            else if (viewModel.PostType == PostType.FoundItemPost)
            {
                newPost = new FoundItemPost();
            }
            else if (viewModel.PostType == PostType.LostItemPost)
            {
                newPost = new LostItemPost
                {
                    Place = viewModel.Place
                };
            }
            else if (viewModel.PostType == PostType.PetAdoptionPost)
            {
                newPost = new PetAdoptionPost
                {
                    IsFullyVaccinated = viewModel.IsFullyVaccinated,
                    AgeInMonths = viewModel.AgeInMonths ?? 0
                };
            }
            else if (viewModel.PostType == PostType.TravellingPost)
            {
                var travellingPost = new TravellingPost
                {
                    Origin = viewModel.Origin,
                    Destination = viewModel.Destination,
                    TravelTime = viewModel.TravelTime,
                    Price = viewModel.PriceT ?? 0
                };

                

                travellingPost.Quota = viewModel.Quota ?? 0;

                newPost = travellingPost;
            }
            else
            {
                throw new InvalidOperationException("Unknown post type");
            }

            InitializeSharedProperties(newPost, viewModel);
            return newPost;
        }
    }
}
