using Restaurant.Application.DTO.ItemsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Application.Interface.User.Items
{
    public interface IItemService
    {
        Task<IEnumerable<ItemDTO?>> GetItemsAsync();

        Task<ItemDTO?> GetItemByIdAsync(int Id);
    }
}
