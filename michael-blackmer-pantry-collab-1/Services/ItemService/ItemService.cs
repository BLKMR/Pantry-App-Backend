using michael_blackmer_pantry_collab_1.Models;
using Microsoft.EntityFrameworkCore;

namespace michael_blackmer_pantry_collab_1.Services.ItemService
{
    public class ItemService : IItemService
    {

        private readonly DataContext _context;

        public ItemService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Item>> GetAllItems()
        {
            var items = await _context.Items.ToListAsync();
            return items;
        }

        public async Task AddItem(Item item)
        {

            var itemExists = await _context.Items.FirstOrDefaultAsync(u => u.Name == item.Name);


            if (itemExists is null)
            {
                //Same problem here with adding an item and sharing the same FamilyId based on user uploading it

                var newItem = new Item
                {                  
                    Id = item.Id,
                    Name = item.Name,
                    Image = item.Image,
                    Calories = item.Calories,
                    Weight= item.Weight,
                    Quantity= item.Quantity,
                    PantryName = item.PantryName,
                    FamilyId = item.Id,
                };

                _context.Items.Add(newItem);
                await _context.SaveChangesAsync();
                return;

            }

            throw new Exception("Item name used");

        }

    }
     
}
