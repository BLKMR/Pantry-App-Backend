using michael_blackmer_pantry_collab_1.Models;

namespace michael_blackmer_pantry_collab_1.Services.ItemService
{
    public interface IItemService
    {
        Task<List<Item>> GetAllItems();

        Task AddItem(Item item);    

    }
}
