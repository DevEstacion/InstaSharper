using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using System.Threading.Tasks;

namespace InstaSharper.API.Processors
{
    public interface ICollectionProcessor
    {
        Task<IResult<InstaCollectionItem>> GetCollectionAsync(long collectionId);

        Task<IResult<InstaCollections>> GetCollectionsAsync();

        Task<IResult<InstaCollectionItem>> CreateCollectionAsync(string collectionName);

        Task<IResult<bool>> DeleteCollectionAsync(long collectionId);

        Task<IResult<InstaCollectionItem>> AddItemsToCollectionAsync(long collectionId, params string[] mediaIds);
    }
}