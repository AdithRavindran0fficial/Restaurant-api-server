using Restaurant.Application.DTO.ItemsDTO;
using Restaurant.Application.Interface.User.Items;
using Restaurant.Domain.Interface.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Application.Service.User.Items
{
    public class ItemsService : IItemService
    {
        private readonly IItemRepository _itemRepo;
        public ItemsService(IItemRepository itemRepository)
        {
            _itemRepo = itemRepository;
        }
        public async Task<ItemDTO?> GetItemByIdAsync(int Id)
        {
            try
            {
                var result = await _itemRepo.GetItemById(Id);
                if (result != null)
                {
                    var item = new ItemDTO
                    {
                        Id = result.ItemId,
                        Title = result.Title,
                        Description = result.Description,                  
                        Image = result.Image
                    };
                    return item;
                    
                }
                return null;

            }

            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<ItemDTO?>> GetItemsAsync()
        {
            try
            {
                var results = await _itemRepo.GetItemsUser();
                if (results.Any())
                {
                    var items = results.Select(item => new ItemDTO
                    {
                        Id = item.ItemId,
                        Title = item.Title,
                        Description = item.Description,
                        Image = item.Image

                    }).ToList();
                    return items;
                }
                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

      
    }
}
