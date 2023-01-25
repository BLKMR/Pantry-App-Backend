using michael_blackmer_pantry_collab_1.Models;
using michael_blackmer_pantry_collab_1.Services.ItemService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace michael_blackmer_pantry_collab_1.Controllers
{
    [EnableCors("localhost")]
    [Route("api/Items")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Item>>> GetAllItems()
        {
            return await _itemService.GetAllItems();
        }

        [HttpPost]
        public async Task<ActionResult> AddItem(Item item)
        {
             await _itemService.AddItem(item);
            return Ok(item);
        }
    }
}
