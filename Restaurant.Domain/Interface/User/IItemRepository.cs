using Restaurant.Domain.Models.UserModels.ItemModel;

namespace Restaurant.Domain.Interface.User
{
    public interface IItemRepository
    {
        
        Task<IEnumerable<Item>> GetItemsUser();
        Task<Item?>GetItemById(int Id);

    }
}
