using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using System.Threading.Tasks;

namespace InstaSharper.API.Processors
{
    public interface IStoryProcessor
    {
        Task<IResult<InstaStoryFeed>> GetStoryFeedAsync();

        Task<IResult<InstaStory>> GetUserStoryAsync(long userId);

        Task<IResult<InstaStoryMedia>> UploadStoryPhotoAsync(InstaImage image, string caption);

        Task<IResult<InstaStoryMedia>> ConfigureStoryPhotoAsync(InstaImage image, string uploadId, string caption);

        Task<IResult<InsteReelFeed>> GetUserStoryFeedAsync(long userId);
    }
}