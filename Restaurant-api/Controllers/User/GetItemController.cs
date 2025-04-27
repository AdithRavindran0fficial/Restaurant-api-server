using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Application.Interface.User.Items;

namespace Restaurant_api.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        public GetItemController(IItemService itemService)
        {
            _itemService = itemService;
        }
        [HttpGet]
        public async Task<IActionResult>GetItem(int id)
        {
            try
            {
                var item = await _itemService.GetItemByIdAsync(id);
                if(item != null)
                {
                    return Ok(item);
                }
                return NotFound();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
