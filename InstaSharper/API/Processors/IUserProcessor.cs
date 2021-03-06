﻿using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using System.Threading.Tasks;

namespace InstaSharper.API.Processors
{
    public interface IUserProcessor
    {
        Task<IResult<InstaMediaList>> GetUserMediaAsync(string username, int maxPages = 0);

        Task<IResult<InstaUser>> GetUserAsync(string username);

        Task<IResult<InstaCurrentUser>> GetCurrentUserAsync();

        Task<IResult<InstaUserShortList>> GetUserFollowersAsync(string username,
            PaginationParameters paginationParameters);

        Task<IResult<InstaUserShortList>> GetUserFollowingAsync(string username,
            PaginationParameters paginationParameters);

        Task<IResult<InstaUserShortList>> GetCurrentUserFollowersAsync(PaginationParameters paginationParameters);

        Task<IResult<InstaMediaList>> GetUserTagsAsync(string username, int maxPages = 0);

        Task<IResult<InstaFriendshipStatus>> FollowUserAsync(long userId);

        Task<IResult<InstaFriendshipStatus>> UnFollowUserAsync(long userId);

        Task<IResult<InstaFriendshipStatus>> BlockUserAsync(long userId);

        Task<IResult<InstaFriendshipStatus>> UnBlockUserAsync(long userId);

        Task<IResult<InstaFriendshipStatus>> GetFriendshipStatusAsync(long userId);
    }
}