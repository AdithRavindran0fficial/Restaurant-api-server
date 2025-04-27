using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Application.Interface.User.Items;

namespace Restaurant_api.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemService;
        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet("GetItems")]
        public async Task<IActionResult> GetAllItems()
        {
            try
            {
                var items = await _itemService.GetItemsAsync();
                
                    return Ok(items);
            
            }
            catch(Exception exx)
            {
                return StatusCode(500, exx.Message);
            }
            
        }
    }
}
