using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using System.Threading.Tasks;

namespace InstaSharper.API.Processors
{
    public interface ILocationProcessor
    {
        Task<IResult<InstaLocationShortList>> Search(double latitude, double longitude, string query);

        Task<IResult<InstaLocationFeed>> GetFeed(long locationId, PaginationParameters paginationParameters);
    }
}