using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using System.Threading.Tasks;

namespace InstaSharper.API.Processors
{
    public interface IMessagingProcessor
    {
        Task<IResult<InstaDirectInboxContainer>> GetDirectInboxAsync();

        Task<IResult<InstaDirectInboxThread>> GetDirectInboxThreadAsync(string threadId);

        Task<IResult<InstaDirectInboxThreadList>> SendDirectMessage(string recipients, string threadIds,
            string text);

        Task<IResult<InstaRecipients>> GetRecentRecipientsAsync();

        Task<IResult<InstaRecipients>> GetRankedRecipientsAsync();
    }
}