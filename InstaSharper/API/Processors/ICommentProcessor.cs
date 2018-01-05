using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using System.Threading.Tasks;

namespace InstaSharper.API.Processors
{
    public interface ICommentProcessor
    {
        Task<IResult<InstaCommentList>>
            GetMediaCommentsAsync(string mediaId, PaginationParameters paginationParameters);

        Task<IResult<InstaComment>> CommentMediaAsync(string mediaId, string text);

        Task<IResult<bool>> DeleteCommentAsync(string mediaId, string commentId);
    }
}